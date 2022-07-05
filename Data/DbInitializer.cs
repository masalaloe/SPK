using SPK.Models;

namespace SPK.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            // Look for any students.
            if (context.Symptoms.Any())
            {
                return;   // DB has been seeded
            } 
            else
            {
                var symptoms = new Symptom[]
                {
                    new Symptom { SymptomID = "G001" ,Name = "Batuk"},
                    new Symptom { SymptomID = "G002" ,Name = "Pilek"},
                    new Symptom { SymptomID = "G003" ,Name = "Mata merah"},
                    new Symptom { SymptomID = "G004" ,Name = "Ruam Kemerahan menyeluruh berisi air"},
                    new Symptom { SymptomID = "G005" ,Name = "Tanda Bahaya Umum"},
                    new Symptom { SymptomID = "G006" ,Name = "Kaku kuduk"},
                    new Symptom { SymptomID = "G007" ,Name = "Usia kurang dari 3 bulan"},
                    new Symptom { SymptomID = "G008" ,Name = "Kornea mata keruh"},
                    new Symptom { SymptomID = "G009" ,Name = "Luka di mulut luas atau dalam"},
                    new Symptom { SymptomID = "G010" ,Name = "Ada nanah pada mata"},
                    new Symptom { SymptomID = "G011" ,Name = "Luka pada mulut"},
                    new Symptom { SymptomID = "G012" ,Name = "Tanda syok"},
                    new Symptom { SymptomID = "G013" ,Name = "Nyeri ulu hati"},
                    new Symptom { SymptomID = "G014" ,Name = "Muntah"},
                    new Symptom { SymptomID = "G015" ,Name = "Pendarahan (Kulit/Hidung/BAB)"},
                    new Symptom { SymptomID = "G016" ,Name = "Tanda syokDemam mendadak tinggi terus menerus"}
                };

                context.Symptoms.AddRange(symptoms);
                context.SaveChanges();                
            }

            // Look for any students.
            if (context.Solutions.Any())
            {
                return;   // DB has been seeded
            }
            else
            {
                var solutions = new Solution[]
                {
                    new Solution { SolutionID = "S001", Name  = "Dosis Paracetamol" },
                    new Solution { SolutionID = "S002", Name  = "Beri dosis pertama antibiotik yang sesuai" },
                    new Solution { SolutionID = "S003", Name  = "Cegah agar gula tidak turun" },
                    new Solution { SolutionID = "S004", Name  = "Beri vitamin A\r\n" },
                    new Solution { SolutionID = "S005", Name  = "Berikan salep mata antibiotik" },
                    new Solution { SolutionID = "S006", Name  = "Oleskan antiseptk mulut" },
                    new Solution { SolutionID = "S007", Name  = "Oralit atau cairan lain" },
                    new Solution { SolutionID = "S008", Name  = "Rujuk segera" },
                };

                context.Solutions.AddRange(solutions);
                context.SaveChanges();
            }

            if (context.Diseases.Any())
            {
                return;   // DB has been seeded
            }
            else
            {
                var diseases = new Disease[]
                {
                    new Disease { DiseaseID = "P001", Name = "Demam disertai penyakit berat"},
                    new Disease { DiseaseID = "P002", Name = "Campak dengan komplikasi berat"},
                    new Disease { DiseaseID = "P003", Name = "Campak dengan komplikasi pada mata atau mulut"},
                    new Disease { DiseaseID = "P004", Name = "Campak"},
                    new Disease { DiseaseID = "P005", Name = "Demam berdarah dengue"},
                    new Disease { DiseaseID = "P006", Name = "Mungkin demam berdarah dengue"}
                };

                context.Diseases.AddRange(diseases);
                context.SaveChanges();
            }
        }
    }
}
