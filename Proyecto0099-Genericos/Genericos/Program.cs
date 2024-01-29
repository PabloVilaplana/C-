namespace genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

             archivos.agregar("Juan");
             archivos.agregar("Elena");
             archivos.agregar("Antonio");
             archivos.agregar("Sandra");


            //archivos.agregar(new Empleado(1500));
            //archivos.agregar(new Empleado(2500));
            //archivos.agregar(new Empleado(3500));
            //archivos.agregar(new Empleado(4500));

            //String nombrePersona = (String)archivos.getElemento(2);
            //Empleado salarioEmpleado = archivos.getElemento(2);
            String nombrePersona = archivos.getElemento(2);

            //Console.WriteLine(nombrePersona);
            Console.WriteLine(nombrePersona);


        }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        private T[] datosElemento;

        private int i = 0;

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }



    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return getSalario();
        }

        private double salario;

    }
}
    
