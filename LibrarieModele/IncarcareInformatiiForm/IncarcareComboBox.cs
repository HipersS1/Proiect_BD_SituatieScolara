﻿using System;
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

        #region Incarcare informatii Facultate

        /// <summary>
        /// Incarca componenta de tip comboBox cu informatiile predefinite din clasa ProgramStudiu
        /// </summary>
        /// <param name="comboBox">componenta combobox</param>
        public static void IncarcaProgramStudiu(ComboBox comboBox)
        {
            foreach (var specializare in Ciclu.GetProgrameStudii())
            {
                comboBox.Items.Add(specializare);
            }
        }

        //public static void IncarcaProgrameStudiiFacultate(ComboBox comboBox, List<Facultate> facultati, string denumire)
        //{
        //    var programe = facultati.Where(f => f.Denumire == denumire).Select(f => f.ProgramStudiu).Distinct().ToList();
        //    foreach (var item in programe)
        //    {
        //        comboBox.Items.Add(item);
        //    }
        //}


        /// <summary>
        /// Incarca comboBox cu denumirile existente 
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="facultati"></param>
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
        /// Incarca comboBox cu specializarile existente 
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="facultati"></param>
        //public static void IncarcaSpecializari(ComboBox comboBox, List<Facultate> facultati)
        //{
        //    var specializari = facultati.Select(f => f.Specializare).Distinct().ToList();
        //    foreach (var specializare in specializari)
        //    {
        //        comboBox.Items.Add(specializare);
        //    }
        //}


        /// <summary>
        /// Incarca combobox 'specializari' cu informatiile specifice facultatii cu denumirea aleasa
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="facultati"></param>
        /// <param name="denumire"></param>
        //public static void IncarcaSpecializariFacultate(ComboBox comboBox, List<Facultate> facultati, string denumire)
        //{
        //    var specializari = facultati.Where(f => f.Denumire == denumire).Select(f => f.Specializare).Distinct().ToList();
        //    foreach (var item in specializari)
        //    {
        //        comboBox.Items.Add(item);
        //    }
        //}
        /// <summary>
        /// Incarca combobox 'specializari' cu informatiile specifice facultatii cu denumirea si programului de studiu ales
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="facultati"></param>
        /// <param name="denumire"></param>
        /// <param name="specializare"></param>
        //public static void IncarcaSpecializariFacultate(ComboBox comboBox, List<Facultate> facultati, string denumire, string programStudiu)
        //{
            
        //    var specializari = facultati.Where(f => f.Denumire == denumire && f.ProgramStudiu == programStudiu).Select(f => f.Specializare).ToList();
        //    foreach (var item in specializari)
        //    {
        //        comboBox.Items.Add(item);
        //    }
        //    if (comboBox.Items.Count == 0)
        //    {
        //        comboBox.Items.Add("-Specializare inexistenta-");
        //    }
        //}

        /// <summary>
        /// Incarca cu valori numerice: ex pentru durata de 1-6 ani
        /// </summary>
        /// 
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

        //public static void IncarcaAniStudent(ComboBox comboBox, List<Facultate> facultati, string denumire, string programStudiu, string specializare)
        //{

        //    var ani = facultati.Where(f => f.Denumire == denumire && f.ProgramStudiu == programStudiu && f.Specializare == specializare)
        //                                .Select(f => f.Durata).ToList();
        //    if (ani.Count > 0)
        //        IncarcaValoriNumerice(comboBox, ani.FirstOrDefault());

        //}

        #endregion

    }
}