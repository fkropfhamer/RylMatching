using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace RylMatching;
public class MatchingAlgorithm
{
    public static void test() {
        Console.WriteLine("test");
    }

    public static void ReadMentorCsv(string path) {
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<MentorCSV>();

            foreach (MentorCSV record in records) {
                Console.WriteLine(record.Id);
                Console.WriteLine(record.Name);
                Console.WriteLine(record.Birthdate);
                Console.WriteLine(record.Hobbies);
            }
        }
    }

    public class MentorCSV
    {
        [Name("Index")]
        public int Id { get; set; }

        [Name("Vorname")]
        public string Name { get; set; }

        [Name("Nachname")]
        public string Surname { get; set; }

        [Name("Geburtsdatum")]
        public string Birthdate { get; set; }

        [Name("E-Mail-Adresse")]
        public string EmailAddress { get; set; }

        [Name("Handynummer")]
        public string PhoneNumber { get; set; }

        [Name("Geschlecht")] 
        public string Sex { get; set; }

        [Name("Strasse")]
        public string Street { get; set; }

        [Name("Hausnummer")]
        public int HouseNumber { get; set; }

        [Name("Postleitzahl")]
        public string PostCode { get; set; }

        [Name("Stadt")]
        public string City { get; set; }

        [Name("Muttersprache")]
        public string NativeLanguage { get; set; }

        [Name("Fremdsprachen")]
        public string ForeignLanguages { get; set; }

        [Name("Fachrichtung")]
        public string Specialization { get; set; }

        [Name("Berufsausbildung")]
        public string CompletedVocationalTraining { get; set; }

        [Name("Zweiter Bildungsweg")]
        public string SecondEducationPath { get; set; }

        [Name("Filme und Serien")]
        public string Movies { get; set; }

        [Name("Musik")]
        public string Music { get; set; }

        [Name("Sport")]
        public string Sport { get; set; }

        [Name("Hobbies")]
        public string Hobbies { get; set; }

    }
}


