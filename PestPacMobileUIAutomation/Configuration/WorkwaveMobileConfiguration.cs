namespace WorkWave.Workwave.Mobile.Configuration
{
    sealed internal class WorkwaveMobileConfiguration
    {
        public string Default_Email { get; set; }
        public string Default_Password { get; set; }
        public string RandomVariableID { get; set; }
        public bool LogInStatus { get; set; }
        public string TimedInStatus { get; set; }
        public string CurrentSessionOrderLocation { get; set; }
    }
}
