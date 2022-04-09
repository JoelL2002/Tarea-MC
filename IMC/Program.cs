using IMC;

Clse_IMC IMC = new Clse_IMC();

IMC.getdatos();
IMC.formula();
IMC.verificacionEtapa();
Console.Clear();
Console.WriteLine("Recuerde que los datos obtenidos no deben de ser tomados como unica fuente\nSi tiene dudas puede consultar con algun especialista\n\n");
Console.WriteLine(IMC.ToString());
