namespace Rhythm.ImportIPLocationData
{

    // Namespaces.
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Windows.Forms;


    /// <summary>
    /// Form.
    /// </summary>
    public partial class frmMain : Form
    {

        #region Constants

        private const string CMD_INSERT = @"INSERT INTO ipLocations (num_start, num_end, latitude, longitude, specificity) VALUES (@num_start, @num_end, @latitude, @longitude, @specificity);";

        #endregion


        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        /// <summary>
        /// "Import" clicked.
        /// </summary>
        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportFromFiles();
        }


        /// <summary>
        /// "Pick Blocks" clicked.
        /// </summary>
        private void btnPickBlocks_Click(object sender, EventArgs e)
        {
            var path = GetPickedFile("CSV|*.csv");
            if (path != null)
            {
                txtBlocks.Text = path;
            }
        }


        /// <summary>
        /// "Pick Location" clicked.
        /// </summary>
        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            var path = GetPickedFile("CSV|*.csv");
            if (path != null)
            {
                txtLocation.Text = path;
            }
        }


        /// <summary>
        /// Link clicked in instructions.
        /// </summary>
        private void richInstructions_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        #endregion


        #region Helper Methods

        /// <summary>
        /// Imports the CSV files into the database.
        /// </summary>
        private void ImportFromFiles()
        {

            // Variables.
            var strConnection = txtConnection.Text;
            var pathLocations = txtLocation.Text;
            var pathRanges = txtBlocks.Text;
            var streamLocations = new StreamReader(pathLocations);
            var readerLocations = new CsvHelper.CsvReader(streamLocations);
            var streamRanges = new StreamReader(pathRanges);
            var readerRanges = new CsvHelper.CsvReader(streamRanges);
            var locations = null as object;
            var ranges = null as object;
            var count = 0;


            // Read locations from CSV.
            while (readerLocations.Read())
            {
                locations = AddItem(new
                {
                    id = readerLocations.GetField<string>(0),
                    country = readerLocations.GetField<string>(1),
                    region = readerLocations.GetField<string>(2),
                    city = readerLocations.GetField<string>(3),
                    postalCode = readerLocations.GetField<string>(4),
                    latitude = readerLocations.GetField<string>(5),
                    longitude = readerLocations.GetField<string>(6),
                    metroCode = readerLocations.GetField<string>(7),
                    areaCode = readerLocations.GetField<string>(8)
                }, locations, out count);
            }


            // Read ranges from CSV.
            while (readerRanges.Read())
            {
                ranges = AddItem(new
                {
                    startIpNum = readerRanges.GetField<string>(0),
                    endIpNum = readerRanges.GetField<string>(1),
                    id = readerRanges.GetField<string>(2)
                }, ranges, out count);
            }


            // Store locations by their ID.
            var byId = new Dictionary<string, object>();
            foreach (var location in (locations as dynamic))
            {
                byId[location.id] = location;
            }


            // Store locations to database by IP range.
            var total = (double)((ranges as dynamic).Count);
            count = 0;
            using(var conn = new SqlConnection(strConnection))
            {
                conn.Open();
                foreach (var range in (ranges as dynamic))
                {

                    // Variables.
                    count++;
                    var percent = count / total * 100;
                    var location = byId[range.id];
                    var specificity = Truthy(location.country) + Truthy(location.region) +
                        Truthy(location.city) + Truthy(location.postalCode) +
                        Truthy(location.metroCode) + Truthy(location.areaCode);


                    // Insert record.
                    using (var cmd = new SqlCommand(CMD_INSERT, conn))
                    {
                        cmd.Parameters.AddWithValue("num_start", long.Parse(range.startIpNum));
                        cmd.Parameters.AddWithValue("num_end", long.Parse(range.endIpNum));
                        cmd.Parameters.AddWithValue("latitude", double.Parse(location.latitude));
                        cmd.Parameters.AddWithValue("longitude", double.Parse(location.longitude));
                        cmd.Parameters.AddWithValue("specificity", (int)specificity);
                        cmd.ExecuteNonQuery();
                    }

                }
                conn.Close();
            }

        }


        /// <summary>
        /// Adds an item to a list.
        /// </summary>
        /// <typeparam name="T">The type of items in the list.</typeparam>
        /// <param name="item">The item to add to the list.</param>
        /// <param name="list">The list to add to (if null, a new list will be created).</param>
        /// <param name="newCount">The new count of items in the list.</param>
        /// <returns>The list.</returns>
        /// <remarks>This is useful for anonymous types.</remarks>
        private List<T> AddItem<T>(T item, object list, out int newCount)
        {
            var typedList = list as List<T>;
            if (typedList == null)
            {
                typedList = new List<T>();
            }
            typedList.Add(item);
            newCount = typedList.Count;
            return typedList;
        }


        /// <summary>
        /// Detects if a string is truthy (not null or whitespace).
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>True, if the string is truthy; otherwise, false.</returns>
        private int Truthy(string str)
        {
            return string.IsNullOrWhiteSpace(str) ? 0 : 1;
        }


        /// <summary>
        /// Gets a picked file path.
        /// </summary>
        /// <param name="filter">The filter to use when the user picks a file (e.g., "CSV|*.csv").</param>
        /// <returns>The file path (or null).</returns>
        private string GetPickedFile(string filter)
        {
            var picker = new OpenFileDialog()
            {
                Filter = filter,
                Multiselect = false
            };
            if (picker.ShowDialog() == DialogResult.OK)
            {
                return picker.FileName;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }

}