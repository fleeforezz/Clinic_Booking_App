namespace Clinic.Common
{
    public class Const
    {
        #region Error Codes
        public static int ERRROR_EXEPTION = -4;
        #endregion

        #region Success Codes
        public static int SUCCESS_CREATE_CODE = 1;
        public static string SUCCESS_CREATE_MESSAGE = "Data save success";
        public static int SUCCESS_READ_CODE = 1;
        public static string SUCCESS_READ_MESSAGE = "Get data success";
        public static int SUCCESS_UPDATE_CODE = 1;
        public static string SUCCESS_UPDATE_MESSAGE = "Data update success";
        public static int SUCCESS_DELETE_CODE = 1;
        public static string SUCCESS_DELETE_MESSAGE = "Data delete success";
        #endregion

        #region Fail code
        public static int FAIL_CREATE_CODE = -1;
        public static string FAIL_CREATE_MESSAGE = "Data save fail";
        public static int FAIL_READ_CODE = -1;
        public static string FAIL_READ_MESSAGE = "Get data fail";
        public static int FAIL_UPDATE_CODE = -1;
        public static string FAIL_UPDATE_MESSAGE = "Data update fail";
        public static int FAIL_DELETE_CODE = -1;
        public static string FAIL_DELETE_MESSAGE = "Delete data fail";
        #endregion

        #region Warning Code
        public static int WARNING_NO_DATA_CODE = 4;
        public static string WARNING_NO_DATA_MESSAGE = "No data";
        #endregion
    }
}
