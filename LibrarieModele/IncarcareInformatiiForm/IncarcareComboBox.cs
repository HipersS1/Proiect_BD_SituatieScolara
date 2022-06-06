using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarieModele
{
    /// <summary>
    /// Clasa ajuta la incarcarea informatiilor predefinite in componentele de tip ComboBox
    /// </summary>
    public static class IncarcareComboBox
    {
        public const string notFound = "Niciun rezultat gasit";
        #region Incarcare informatii Facultate

        /// <summary>
        /// Incarca componenta de tip comboBox cu informatiile predefinite din clasa Ciclu
        /// </summary>
        /// <param name="comboBox">componenta combobox</param>
        public static void IncarcaProgramStudiu(ComboBox comboBox)
        {
            foreach (var specializare in Ciclu.GetProgrameStudii())
            {
                comboBox.Items.Add(new ComboItem(specializare));
            }
        }

        /// <summary>
        /// Incarca combobox cu ciclurile de studii pentru facultatea selectata
        /// </summary>
        public static void IncarcaProgrameStudiiFacultate(ComboBox comboBox, List<ProgramStudiu> programeStudii, int idFacultate)
        {
            var programe = programeStudii.Where(f => f.IdFacultate == idFacultate)
                                         .Select(f => f.Ciclu)
                                         .Distinct()
                                         .ToList();
            foreach (var item in programe)
            {
                comboBox.Items.Add(new ComboItem(item));
            }
            if (comboBox.Items.Count == 0)
            {
                comboBox.Items.Add(new ComboItem(notFound));
            }
        }
        /// <summary>
        /// Incarca combobox cu specializarile facultatii selectate si ciclului de studiu selectat
        /// </summary>
        public static void IncarcaSpecializariFacultate(ComboBox comboBox, List<ProgramStudiu> programeStudii, int idFacultate, string cicluStudiu)
        {
            var specializari = programeStudii.Where(f => f.IdFacultate == idFacultate && f.Ciclu == cicluStudiu)
                                             .Select(f => f.Specializare)
                                             .Distinct()
                                             .ToList();
            foreach (var specializare in specializari)
            {
                comboBox.Items.Add(new ComboItem(specializare));
            }
            if (comboBox.Items.Count == 0)
            {
                comboBox.Items.Add(new ComboItem(notFound));
            }
        }
        /// <summary>
        /// Incarca combobox cu specializarile facultatii selectate
        /// </summary>
        public static void IncarcaSpecializariFacultate(ComboBox comboBox, List<ProgramStudiu> programeStudii, int idFacultate)
        {
            var specializari = programeStudii.Where(f => f.IdFacultate == idFacultate)
                                             .Select(f => f.Specializare)
                                             .Distinct()
                                             .ToList();
            foreach (var specializare in specializari)
            {
                comboBox.Items.Add(new ComboItem(specializare));
            }
            if (comboBox.Items.Count == 0)
            {
                comboBox.Items.Add(new ComboItem(notFound));
            }
        }

        /// <summary>
        /// Incarca combobox cu anii programului de studiu si facultatii selectate
        /// </summary>
        public static void IncarcaAniStudent(ComboBox comboBox, List<ProgramStudiu> programeStudii, int idFacultate, string cicluStudiu, string specializare)
        {

            var ani = programeStudii.Where(f => f.IdFacultate == idFacultate && f.Ciclu == cicluStudiu && f.Specializare == specializare)
                                    .Select(f => f.Durata)
                                    .FirstOrDefault();
            
            IncarcaValoriNumerice(comboBox, ani);
        }

        /// <summary>
        /// Incarca comboBox cu denumirile facultatilor din BD
        /// </summary>
        public static void IncarcaDenumiriFacultati(ComboBox comboBox, List<Facultate> facultati)
        {
            var listFacultati = facultati.Select(f => new { f.IdFacultate, f.Denumire })
                                         .OrderBy(f => f.Denumire)
                                         .ToList();
            foreach (var denumire in listFacultati)
            {
                comboBox.Items.Add(new ComboItem(denumire.Denumire, denumire.IdFacultate));
            }
        }

        /// <summary>
        /// Incarca cu valori numerice: ex pentru durata de 1-6 ani
        /// </summary>
        public static void IncarcaValoriNumerice(ComboBox comboBox, int maxim)
        {
            if(maxim <= 0)
            {
                return;
            }

            for (int i = 1; i <= maxim; i++)
            {
                comboBox.Items.Add(i);
            }
        }

        public static void IncarcaValoriNumerice(ComboBox comboBox, int min, int maxim)
        {
            if (maxim <= 0)
            {
                return;
            }

            for (int i = min; i <= maxim; i++)
            {
                comboBox.Items.Add(i);
            }
        }

        #endregion

    }
}
