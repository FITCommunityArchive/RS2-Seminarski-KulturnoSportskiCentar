using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eKulturnoSportskiCentar_API.Util
{
    public class ExceptionHandler
    {
        public static string HandleException(EntityException ex)
        {
            SqlException error = ex.InnerException as SqlException;

            switch (error.Number)
            {
                case 2627:
                    return GetConstraintExceptionMessage(error);

                default:
                    return error.Message + "(" + error.Number + ")";

            }
        }

        private static string GetConstraintExceptionMessage(SqlException error)
        {
            string NewMessage = error.Message;

            int startIndex = NewMessage.IndexOf("'");
            int endIndex = NewMessage.IndexOf("'", startIndex + 1);
            if (startIndex > 0 && endIndex > 0)
            {
                string cnstraintName = NewMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

                switch (cnstraintName)
                {
                    case "UQ__KorisnickoIme":
                        NewMessage = "username_con";
                        break;
                    case "UQ__Korisnik__Email":
                        NewMessage = "email_con";
                        break;
                    case "UQ_Korisnik_Dogadjaj":
                        {
                            NewMessage = "Korisnik_Dogadjaj_con";
                            break;
                        }


                }
            }
            return NewMessage;
        }
    }
}