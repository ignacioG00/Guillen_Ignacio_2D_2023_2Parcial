namespace Carniceria
{
    public abstract class Usuario
    {
        string nombre;
        string mail;
        string contraseña;

        public Usuario() 
        {
        
        }
        public Usuario(string nombre, string mail, string contraseña)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.contraseña = contraseña;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Mail 
        {
            get { return mail; }
            set { mail = value; }    
        }

        public string Contraseña 
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public virtual bool ComprobarContra(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado));
        }
    }
}