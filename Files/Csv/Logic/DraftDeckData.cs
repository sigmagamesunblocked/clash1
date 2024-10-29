namespace ClashRoyale.Files.Csv.Logic
{
    public class DraftDeckData : CsvData
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DraftDeckData" /> class.
        /// </summary>
        /// <param name="CsvRow">The row.</param>
        /// <param name="CsvTable">The data table.</param>
        public DraftDeckData(CsvRow CsvRow, CsvTable CsvTable) : base(CsvRow, CsvTable)
        {
            // DraftDeckData.
        }

        public string[] RequiredSets { get; set; }

        public string[] OptionalSets { get; set; }

        /// <summary>
        ///     Called when all instances has been loaded for initialized members in instance.
        /// </summary>
        public override void LoadingFinished()
        {
            // LoadingFinished.
        }
    }
}