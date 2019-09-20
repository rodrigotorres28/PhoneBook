using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact.Contact dueño = new Contact.Contact("NombreDueño", "0999999", "dueño@gmail.com");
            Contact.Contact contacto1 = new Contact.Contact("Nombre1", "+59899742172", "contacto1@gmail.com");
            contacto1.TwitterID = "13960658118";
            Contact.Contact contacto2 = new Contact.Contact("Nombre2", "5616186408", "contacto2@gmail.com");
            contacto2.TwitterID = "2230668516";

            Phonebook lista = new Phonebook(dueño);

            lista.AddContact(contacto1);
            lista.AddContact(contacto2);

            Message mensaje = new Message(contacto1.phone, contacto2.phone);
            mensaje.Text = "Hola";
            WhatsAppChannel.Send(mensaje);

            Message mensaje = new Message(contacto1.TwitterID, contacto2.TwitterID);
            mensaje.Text = "Hola";
            TwitterChannel.Send(mensaje);

            // Crear el contacto dueño

            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
