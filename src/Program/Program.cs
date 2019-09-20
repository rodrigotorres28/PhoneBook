using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact dueño = new Contact("NombreDueño", "0999999", "dueño@gmail.com");
            Contact contacto1 = new Contact("Nombre1", "+59899742172", "contacto1@gmail.com");
            contacto1.TwitterID = "13960658118";
            Contact contacto2 = new Contact("Nombre2", "+59899742172", "contacto2@gmail.com");
            contacto2.TwitterID = "2230668516";

            Phonebook lista = new Phonebook(dueño);

            lista.AddContact(contacto1);
            lista.AddContact(contacto2);

            Message mensajeW = new Message(contacto1, contacto2);
            mensajeW.Text = "Hola";
            WhatsAppChannel wpp = new WhatsAppChannel();
            wpp.Send(mensajeW);

            Message mensajeT = new Message(contacto1, contacto2);
            mensajeT.Text = "Hola";
            TwitterChannel twitter = new TwitterChannel();
            twitter.Send(mensajeT);

            // Crear el contacto dueño

            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
