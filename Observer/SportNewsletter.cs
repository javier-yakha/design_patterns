using System;
namespace Observer
{
    public class SportNewsletter : NewsletterSubject
    {
        private Newsletter currentNewsletter;

        public SportNewsletter(Newsletter newsletter)
        {
            this.currentNewsletter = newsletter;
        }
        // Method to retrieve the current newsletter
        public Newsletter GetNewsletter()
        {
            return currentNewsletter;
        }

        // Method to set a new newsletter and notify all observers
        public void SetNewsletter(Newsletter newNewsletter)
        {
            currentNewsletter = newNewsletter;
            Console.WriteLine("Es ist ein neuer Newsletter erschienen: " + currentNewsletter.Topic);
            SendNewsletter(currentNewsletter);
        }
    }
}

