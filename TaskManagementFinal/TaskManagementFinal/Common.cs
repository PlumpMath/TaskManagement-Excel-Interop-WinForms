namespace TaskManagementFinal
{
    public static class SharedData
    {
        public const string FILE_PATH = @"D:\TaskManagement.xls";
        public const string FILE_PATH_ASSIGNEES = @"D:\TasksAssignee.xls";
        public const string LOAD_CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FILE_PATH + ";Extended Properties='Excel 8.0;HDR=YES;';";
        public const string LOAD_CONNECTION_STRING_ASSIGNEES = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FILE_PATH_ASSIGNEES + ";Extended Properties='Excel 8.0;HDR=NO;';";
        public const string WORKSHEET_NAME = @"Tasks";
        public const string DATE_PREFIX = @"Dated: ";
        public const string EXCEL_NOT_INSTALLED_WARNING = @"Excel is not installed on this machine!";
        public const string FILE_NOT_FOUND_WARNING = @"File not present, please save again.";
        public const string TEXTBOX_EMPTY_WARNING = @"Text box cannnot be blank.";
        public const string SAVE_SUCCESSFUL_WARNING = @"Save successful";
        public const string SAVE_FAILED_WARNING = @"Could not save.";
        public const string BEFORE_EXIT_WARNING = @"Do you want to save before exiting?";
        public const string NO_PENDING_TASKS = @"There are no tasks for today.";
        public const string BLANK_SPACE = @" ";
        public const string TEXTBOX_CAPTION = @"Closing";
        public const string NO_CHANGES_WARNING = @"No changes were made.";
        public const string ROW_NOT_SELECTED_WARNING = @"No rows selected. Please click on the leftmost cell of a row to select it.";
        public const string MINIMIZED_TIP = "Personal Task Manager minimized";
        public const string MAXIMIZED_TIP = "Personal Task Manager maximized";
        public const string DELIMETER = " :: ";
        public static readonly char[] CHARACTERS_TO_TRIM = new char[] { ' ' };
    }
}
