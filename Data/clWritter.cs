using System.Xml;
using Microsoft.AspNetCore.SignalR;

namespace API_rest.Data
{
    /// <summary>
    /// Clase modelo para writters, id,nickname,style,nacionalidad
    /// </summary>
    public class clWritter     
    {
        private int idWriter;
        public int IdWriter_prop
        {
            get { return idWriter; }
            set { idWriter = value; }
        }
        private string nickname;
        public string Nickname_prop
        {
            get { return nickname; }
            set { nickname = value; }
        }
        private string style;
        public string Style_prop
        {
            get { return style; }
            set { style = value; }
        }
        private string nationality;
        public string Nationality_prop
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public List<clWritter>? writers {get; set;}
 

    }
    
}
