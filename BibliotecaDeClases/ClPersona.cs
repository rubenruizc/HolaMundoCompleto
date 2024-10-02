namespace BibliotecaDeClases
{
    public class ClPersona

    {
        #region Atributos
        private String nombre;
        private String apellido;
        private DateTime fechaNacimiento;
        #endregion

        #region Constructores

        public ClPersona (String nombre, String apellido,DateTime fechaNacimiento)
        {
            if(!nombre.Equals("") && nombre != null)
            {
            this.nombre = nombre;

            }

            if(!apellido.Equals("") && apellido != null)
            {

            this.apellido = apellido;
            }
            this.fechaNacimiento = fechaNacimiento;
        }

        public ClPersona()
        {
            nombre = "Amaru";
            apellido = "Amarillo";
            fechaNacimiento = new DateTime();
        }


        #endregion 

        #region Propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }

        }
        #endregion 
    }
}


   

