// Ablauf.cs (zu V03-Textdokument)

using System;


namespace HausaufgabeV03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n----------\n");

            Textdokument textdokument = new Textdokument();
            textdokument.ZeileZufügen("Dies ist ein Text!");
            Console.WriteLine(textdokument.Text);

            Console.WriteLine("\n----------\n");

            Brief brief = new Brief
            (
                new Kontakt("Frauke Bunt", "Schwarzstraße 99\n99999 Großstaubstadt"),
                new Kontakt("Frank Blümel", "Rosengasse 13a\n99998 Hinterwalden")
            );
            brief.ZeileZufügen("Liebe Frauke,\n");
            brief.ZeileZufügen("wie geht es Dir?");
            brief.ZeileZufügen("Mir geht es gut.\n");
            brief.ZeileZufügen("Dein Frank");
            Console.WriteLine($"An:  {brief.Adressat.Darstellung()}");
            Console.WriteLine($"Von: {brief.Absender.Darstellung()}\n");
            Console.WriteLine(brief.Text);

            Console.WriteLine("\n----------\n");

            Aufsatz aufsatz = new Aufsatz
            (
                "Prof. Dr. I. C. H. B. I. N. Wichtig",
                "Das Liebesleben der Gänseblümchen und seine Bedeutung für den Fortbestand des Universums"
            );
            aufsatz.ZeileZufügen("(in Arbeit)");
            Console.WriteLine(aufsatz.Titel);
            Console.WriteLine($"von: {aufsatz.Autor}\n");
            Console.WriteLine(aufsatz.Text);

            Console.WriteLine("\n----------\n");

            Schulaufsatz s = new Schulaufsatz
            (
                "Konrad Kniefall",
                "Warum brauchen wir Autoritäten?"
            );
            s.ZeileZufügen("Diese Frage bedarf keiner Antwort.");
            Console.WriteLine(s.Titel);
            Console.WriteLine($"von: {s.Autor}\n");
            Console.WriteLine(s.Text);
            Console.WriteLine($"\nNote: {s.Note}");

            Console.WriteLine();

            s.Note = "5.0";
            Console.WriteLine(s.Titel);
            Console.WriteLine($"von: {s.Autor}\n");
            Console.WriteLine(s.Text);
            Console.WriteLine($"\nNote: {s.Note}");

            Console.WriteLine("\n----------\n");

            // Prüfungen zur Durchführung der Plausibilitätsprüfungen
            // Jeder der folgenden Methodenaufrufe sollte zu einem Fehler und so zu einer Ausnahme führen.
            // Falls nicht wird hier eine Ausnahme geworfen.

            Plausiprüf(() => new Kontakt(null, "Schwarzstraße 99\n99999 Großstaubstadt"));

            
            Plausiprüf(() => new Kontakt("", "Schwarzstraße 99\n99999 Großstaubstadt"));
            
            Plausiprüf(() => new Kontakt(" ", "Schwarzstraße 99\n99999 Großstaubstadt"));
            
            Plausiprüf(() => new Kontakt("Frauke Bunt", null));
            Plausiprüf(() => new Kontakt("Frauke Bunt", ""));
            Plausiprüf(() => new Kontakt("Frauke Bunt", " "));
            
            Plausiprüf(() => new Textdokument().ZeileZufügen(null));
            
            Plausiprüf(() => new Aufsatz(null, "Das Liebesleben der Gänseblümchen und seine Bedeutung für den Fortbestand des Universums"));
            

            Plausiprüf(() => new Aufsatz("", "Das Liebesleben der Gänseblümchen und seine Bedeutung für den Fortbestand des Universums"));
            Plausiprüf(() => new Aufsatz(" ", "Das Liebesleben der Gänseblümchen und seine Bedeutung für den Fortbestand des Universums"));
            

            Plausiprüf(() => new Aufsatz("Prof. Dr. I. C. H. B. I. N. Wichtig", null));
            Plausiprüf(() => new Aufsatz("Prof. Dr. I. C. H. B. I. N. Wichtig", ""));
            Plausiprüf(() => new Aufsatz("Prof. Dr. I. C. H. B. I. N. Wichtig", " "));
            

            Plausiprüf(() => new Schulaufsatz("Konrad Kniefall", "Warum brauchen wir Autoritäten?").Note = null);
            Plausiprüf(() => new Schulaufsatz("Konrad Kniefall", "Warum brauchen wir Autoritäten?").Note = "");
            System.Console.WriteLine("a");
            Plausiprüf(() => new Schulaufsatz("Konrad Kniefall", "Warum brauchen wir Autoritäten?").Note = " ");

            Console.WriteLine("OK");

            Console.ReadKey();
        }

        // Methode prüft, ob Plausibilitätsprüfungen durchgeführt werden
        // Der Methodenaufruf ist fehlerhaft und soll zu einer Ausnahme führen.
        // Bleibt die Ausnahme aus so führt das hier zu einer Ausnahme.
        static void Plausiprüf(Action methodenaufruf)
        {
            bool ausnahmeWurdeGeworfen;

            try
            {
                // Methode aufrufen
                methodenaufruf();
                // Oh-oh, erwartete Ausnahme ist nicht gekommen - Fehler!
                ausnahmeWurdeGeworfen = false;
            }
            catch
            {
                // Ausnahme ist erwartet worden, also alles OK
                ausnahmeWurdeGeworfen = true;
            }

            // Ausnahme im Fall der fehlenden erwarteten Ausnahme
            if (!ausnahmeWurdeGeworfen)
                throw new Exception();
        }
    }
}
