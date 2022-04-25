using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quimica
{
    public class Element
    {
        public int AtomicNumber { get; set; }
        public string Name { get; set; }
        public double AtomicMass { get; set; }
        public string Symbol { get; set; }
        public string Electronegativity { get; set; }
        public string ControlName { get; set; }
        public int Group { get; set; }
        public int Period { get; set; }


        public static List<Element> GetAllElements()
        {
            List<Element> AllElements = new List<Element>();

            AllElements.Add(
            new Element
            {
                AtomicNumber = 1,
                Name = "Hidrogeno",
                Symbol = "H",
                AtomicMass = 1.00,
                Electronegativity = "2.1",
                ControlName = "btnHidrogeno",
                Group = 1,
                Period = 1

            }
            );

            AllElements.Add(
                new Element
                {
                    AtomicNumber = 2,
                    Name = "Helio",
                    Symbol = "He",
                    AtomicMass = 4.00,
                    Electronegativity = " - ",
                    ControlName = "btnHelio",
                    Group = 18,
                    Period = 1
                }
                );
            AllElements.Add(
               new Element
               {
                   AtomicNumber = 3,
                   Name = "Litio",
                   Symbol = "Li",
                   AtomicMass = 6.94,
                   Electronegativity = " 1.0 ",
                   ControlName = "btnLitio",
                   Group = 1,
                   Period = 2
               }
               );


            AllElements.Add(
              new Element
              {
                  AtomicNumber = 4,
                  Name = "Berilio",
                  Symbol = "Be",
                  AtomicMass = 9.01,
                  Electronegativity = "1.5",
                  ControlName = "btnBerilio",
                  Group = 2,
                  Period = 2
              }
          );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 5,
                  Name = "Boro",
                  Symbol = "B",
                  AtomicMass = 10.81,
                  Electronegativity = "2.0",
                  ControlName = "btnBoro",
                  Group = 13,
                  Period = 2
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 6,
                  Name = "Carbono",
                  Symbol = "C",
                  AtomicMass = 12.01,
                  Electronegativity = "2.5",
                  ControlName = "btnCarbono",
                  Group = 14,
                  Period = 2
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 7,
                  Name = "Nitrogeno",
                  Symbol = "N",
                  AtomicMass = 14.00,
                  Electronegativity = "3.0",
                  ControlName = "btnNitrogeno",
                  Group = 15,
                  Period = 2

              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 8,
                  Name = "Oxigeno",
                  Symbol = "O",
                  AtomicMass = 15.99,
                  Electronegativity = "3.5",
                  ControlName = "btnOxigeno",
                  Group = 16,
                  Period = 2


              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 9,
                  Name = "Fluor",
                  Symbol = "F",
                  AtomicMass = 18.99,
                  Electronegativity = "4.0",
                  ControlName = "btnFluor",
                  Group = 17,
                  Period = 2


              }
            );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 10,
                  Name = "Neon",
                  Symbol = "Ne",
                  AtomicMass = 20.18,
                  Electronegativity = "-",
                  ControlName = "btnNeon",
                  Group = 10,
                  Period = 2
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 11,
                  Name = "Sodio",
                  Symbol = "Na",
                  AtomicMass = 22.98,
                  Electronegativity = "0.9",
                  ControlName = "btnSodio",
                  Group = 1,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 12,
                  Name = "Magnesio",
                  Symbol = "Mg",
                  AtomicMass = 24.31,
                  Electronegativity = "1.2",
                  ControlName = "btnMagnesio",
                  Group = 2,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 13,
                  Name = "Aluminio",
                  Symbol = "Al",
                  AtomicMass = 26.98,
                  Electronegativity = "1.5",
                  ControlName = "btnAluminio",
                  Group = 13,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 14,
                  Name = "Silicio",
                  Symbol = "Si",
                  AtomicMass = 28.08,
                  Electronegativity = "1.8",
                  ControlName = "btnSilicio",
                  Group = 14,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 15,
                  Name = "Fosforo",
                  Symbol = "P",
                  AtomicMass = 30.97,
                  Electronegativity = "2.1",
                  ControlName = "btnFosforo",
                  Group = 15,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 16,
                  Name = "Azufre",
                  Symbol = "S",
                  AtomicMass = 32.06,
                  Electronegativity = "2.5",
                  ControlName = "btnAzufre",
                  Group = 16,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 17,
                  Name = "Cloro",
                  Symbol = "Cl",
                  AtomicMass = 35.45,
                  Electronegativity = "3.0",
                  ControlName = "btnCloro",
                  Group = 17,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 18,
                  Name = "Argon",
                  Symbol = "Ar",
                  AtomicMass = 39.94,
                  Electronegativity = "-",
                  ControlName = "btnArgon",
                  Group = 18,
                  Period = 3
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 19,
                  Name = "Potasio",
                  Symbol = "K",
                  AtomicMass = 39.10,
                  Electronegativity = "0.8",
                  ControlName = "btnPotasio",
                  Group = 1,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 20,
                  Name = "Calcio",
                  Symbol = "Ca",
                  AtomicMass = 40.08,
                  Electronegativity = "1.0",
                  ControlName = "btnCalcio",
                  Group = 2,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 21,
                  Name = "Escandio",
                  Symbol = "Sc",
                  AtomicMass = 44.95,
                  Electronegativity = "1.3",
                  ControlName = "btnEscandio",
                  Group = 3,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 22,
                  Name = "Titanio",
                  Symbol = "Ti",
                  AtomicMass = 47.90,
                  Electronegativity = "1.6",
                  ControlName = "btnTitanio",
                  Group = 4,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 23,
                  Name = "Vanadio",
                  Symbol = "V",
                  AtomicMass = 50.94,
                  Electronegativity = "1.6",
                  ControlName = "btnVanadio",
                  Group = 5,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 24,
                  Name = "Cromo",
                  Symbol = "Cr",
                  AtomicMass = 52.99,
                  Electronegativity = "1.6",
                  ControlName = "btnCromo",
                  Group = 6,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 25,
                  Name = "Manganeso",
                  Symbol = "Mn",
                  AtomicMass = 54.93,
                  Electronegativity = "1.5",
                  ControlName = "btnMagneso",
                  Group = 7,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 26,
                  Name = "Hierro",
                  Symbol = "Fe",
                  AtomicMass = 55.84,
                  Electronegativity = "1.8",
                  ControlName = "btnHierro",
                  Group = 8,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 27,
                  Name = "Cobalto",
                  Symbol = "Co",
                  AtomicMass = 58.93,
                  Electronegativity = "1.8",
                  ControlName = "btnCobalto",
                  Group = 9,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 28,
                  Name = "Niquel",
                  Symbol = "Ni",
                  AtomicMass = 58.71,
                  Electronegativity = "1.9",
                  ControlName = "btnNiquel",
                  Group = 10,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 29,
                  Name = "Cobre",
                  Symbol = "Cu",
                  AtomicMass = 63.54,
                  Electronegativity = "1.9",
                  ControlName = "btnCobre",
                  Group = 11,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 30,
                  Name = "Cinc",
                  Symbol = "Zn",
                  AtomicMass = 65.37,
                  Electronegativity = "1.6",
                  ControlName = "btnCinc",
                  Group = 12,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 31,
                  Name = "Galio",
                  Symbol = "Ga",
                  AtomicMass = 69.72,
                  Electronegativity = "1.6",
                  ControlName = "btnGalio",
                  Group = 13,
                  Period = 4
              }
              );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 32,
                  Name = "Germanio",
                  Symbol = "Ge",
                  AtomicMass = 72.59,
                  Electronegativity = "1.8",
                  ControlName = "btnGermanio",
                  Group = 14,
                  Period = 4
              }
              );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 33,
                 Name = "Arsenico",
                 Symbol = "As",
                 AtomicMass = 74.92,
                 Electronegativity = "2.0",
                 ControlName = "btnArsenico",
                 Group = 15,
                 Period = 4
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 34,
                 Name = "Selenio",
                 Symbol = "Se",
                 AtomicMass = 78.96,
                 Electronegativity = "2.4",
                 ControlName = "btnSelenio",
                 Group = 16,
                 Period = 4
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 35,
                 Name = "Bromo",
                 Symbol = "Br",
                 AtomicMass = 79.90,
                 Electronegativity = "2.8",
                 ControlName = "btnBromo",
                 Group = 17,
                 Period = 4
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 36,
                 Name = "Cripton",
                 Symbol = "Kr",
                 AtomicMass = 83.80,
                 Electronegativity = "-",
                 ControlName = "btnCripton",
                 Group = 18,
                 Period = 4
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 37,
                 Name = "Rubidio",
                 Symbol = "Rb",
                 AtomicMass = 85.47,
                 Electronegativity = "0.8",
                 ControlName = "btnRubidio",
                 Group = 1,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 38,
                 Name = "Estroncio",
                 Symbol = "Sr",
                 AtomicMass = 87.62,
                 Electronegativity = "1.0",
                 ControlName = "btnEstroncio",
                 Group = 2,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 39,
                 Name = "Itrio",
                 Symbol = "Y",
                 AtomicMass = 88.90,
                 Electronegativity = "1.3",
                 ControlName = "btnItrio",
                 Group = 3,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 40,
                 Name = "Circonio",
                 Symbol = "Zr",
                 AtomicMass = 91.22,
                 Electronegativity = "1.4",
                 ControlName = "btnCirconio",
                 Group = 4,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 41,
                 Name = "Niobio",
                 Symbol = "Nb",
                 AtomicMass = 92.90,
                 Electronegativity = "1.6",
                 ControlName = "btnNiobio",
                 Group = 5,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 42,
                 Name = "Molibdeno",
                 Symbol = "Mo",
                 AtomicMass = 95.94,
                 Electronegativity = "1.8",
                 ControlName = "btnMolibdeno",
                 Group = 6,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 43,
                 Name = "Tecnecio",
                 Symbol = "Tc",
                 AtomicMass = 98.90,
                 Electronegativity = "1.9",
                 ControlName = "btnTecnecio",
                 Group = 7,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 44,
                 Name = "Rutenio",
                 Symbol = "Ru",
                 AtomicMass = 101.07,
                 Electronegativity = "2.2",
                 ControlName = "btnRutenio",
                 Group = 8,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 45,
                 Name = "Rodio",
                 Symbol = "Rh",
                 AtomicMass = 102.90,
                 Electronegativity = "2.2",
                 ControlName = "btnRodio",
                 Group = 9,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 46,
                 Name = "Paladio",
                 Symbol = "Pd",
                 AtomicMass = 106.4,
                 Electronegativity = "2.2",
                 ControlName = "btnPaladio",
                 Group = 10,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 47,
                 Name = "Plata",
                 Symbol = "Ag",
                 AtomicMass = 107.87,
                 Electronegativity = "1.9",
                 ControlName = "btnPlata",
                 Group = 11,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 48,
                 Name = "Cadmio",
                 Symbol = "Cd",
                 AtomicMass = 112.40,
                 Electronegativity = "1.7",
                 ControlName = "btnCadmio",
                 Group = 12,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 49,
                 Name = "Indio",
                 Symbol = "In",
                 AtomicMass = 114.82,
                 Electronegativity = "1.7",
                 ControlName = "btnIndio",
                 Group = 13,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 50,
                 Name = "Estanio",
                 Symbol = "Sn",
                 AtomicMass = 118.69,
                 Electronegativity = "1.8",
                 ControlName = "btnEstanio",
                 Group = 14,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 51,
                 Name = "Antimonio",
                 Symbol = "Sb",
                 AtomicMass = 121.75,
                 Electronegativity = "1.9",
                 ControlName = "btnAntimonio",
                 Group = 15,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 52,
                 Name = "Telurio",
                 Symbol = "Te",
                 AtomicMass = 127.60,
                 Electronegativity = "2.1",
                 ControlName = "btnTelurio",
                 Group = 16,
                 Period = 5
             }
             );
            AllElements.Add(
              new Element
              {
                  AtomicNumber = 53,
                  Name = "Yodo",
                  Symbol = "I",
                  AtomicMass = 126.90,
                  Electronegativity = "2.5",
                  ControlName = "btnYodo",
                  Group = 17,
                  Period = 5
              }
              );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 54,
                 Name = "Xenon",
                 Symbol = "Xe",
                 AtomicMass = 131.30,
                 Electronegativity = "-",
                 ControlName = "btnXenon",
                 Group = 18,
                 Period = 5
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 55,
                 Name = "Cesio",
                 Symbol = "Cs",
                 AtomicMass = 132.90,
                 Electronegativity = "0.7",
                 ControlName = "btnCesio",
                 Group = 1,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 56,
                 Name = "Bario",
                 Symbol = "Ba",
                 AtomicMass = 137.34,
                 Electronegativity = "0.9",
                 ControlName = "btnBario",
                 Group = 2,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 57,
                 Name = "Lantano",
                 Symbol = "La",
                 AtomicMass = 138.91,
                 Electronegativity = "1.1",
                 ControlName = "btnLantano",
                 Group = 3,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 72,
                 Name = "Hafnio",
                 Symbol = "Hf",
                 AtomicMass = 178.49,
                 Electronegativity = "1.3",
                 ControlName = "btnHafnio",
                 Group = 4,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 73,
                 Name = "Tantalio",
                 Symbol = "Ta",
                 AtomicMass = 180.94,
                 Electronegativity = "1.5",
                 ControlName = "btnTantalio",
                 Group = 5,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 74,
                 Name = "Wolframio",
                 Symbol = "W",
                 AtomicMass = 183.85,
                 Electronegativity = "1.7",
                 ControlName = "btnWolframio",
                 Group = 6,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 75,
                 Name = "Renio",
                 Symbol = "Re",
                 AtomicMass = 186.2,
                 Electronegativity = "1.9",
                 ControlName = "btnRenio",
                 Group = 7,
                 Period = 6
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 76,
                 Name = "Osmio",
                 Symbol = "Os",
                 AtomicMass = 190.2,
                 Electronegativity = "2.2",
                 ControlName = "btnOsmio",
                 Group = 8,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 77,
                 Name = "Iridio",
                 Symbol = "Ir",
                 AtomicMass = 192.2,
                 Electronegativity = "2.2",
                 ControlName = "btnIridio",
                 Group = 9,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 78,
                 Name = "Platino",
                 Symbol = "Pt",
                 AtomicMass = 195.09,
                 Electronegativity = "2.2",
                 ControlName = "btnPlatino",
                 Group = 10,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 79,
                 Name = "Oro",
                 Symbol = "Au",
                 AtomicMass = 196.96,
                 Electronegativity = "2.4",
                 ControlName = "btnOro",
                 Group = 11,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 80,
                 Name = "Mercurio",
                 Symbol = "Hg",
                 AtomicMass = 200.59,
                 Electronegativity = "1.9",
                 ControlName = "btnMercurio",
                 Group = 12,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 81,
                 Name = "Talio",
                 Symbol = "Ti",
                 AtomicMass = 204.37,
                 Electronegativity = "1.8",
                 ControlName = "btnTalio",
                 Group = 13,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 82,
                 Name = "Plomo",
                 Symbol = "Pb",
                 AtomicMass = 207.19,
                 Electronegativity = "1.8",
                 ControlName = "btnPlomo",
                 Group = 14,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 83,
                 Name = "Bismuto",
                 Symbol = "Bi",
                 AtomicMass = 208.98,
                 Electronegativity = "1.9",
                 ControlName = "btnBismuto",
                 Group = 15,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 84,
                 Name = "Polonio",
                 Symbol = "Po",
                 AtomicMass = 210,
                 Electronegativity = "2.0",
                 ControlName = "btnPolonio",
                 Group = 16,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 85,
                 Name = "Astato",
                 Symbol = "At",
                 AtomicMass = 210,
                 Electronegativity = "2.2",
                 ControlName = "btnAstato",
                 Group = 17,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 86,
                 Name = "Radon",
                 Symbol = "Rn",
                 AtomicMass = 222,
                 Electronegativity = "-",
                 ControlName = "btnRadon",
                 Group = 18,
                 Period = 6
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 87,
                 Name = "Francio",
                 Symbol = "Fr",
                 AtomicMass = 223,
                 Electronegativity = "0.7",
                 ControlName = "btnFrancio",
                 Group = 1,
                 Period = 7
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 88,
                 Name = "Radio",
                 Symbol = "Ra",
                 AtomicMass = 226,
                 Electronegativity = "0.9",
                 ControlName = "btnRadio",
                 Group = 2,
                 Period = 7
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 89,
                 Name = "Actinio",
                 Symbol = "Ac",
                 AtomicMass = 227,
                 Electronegativity = "1.1",
                 ControlName = "btnActinio",
                 Group = 3,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 104,
                 Name = "Rutherfordio",
                 Symbol = "Rf",
                 AtomicMass = 261,
                 Electronegativity = "-",
                 ControlName = "btnRutherfordio",
                 Group = 4,
                 Period = 7
             }
             );

            AllElements.Add(
             new Element
             {
                 AtomicNumber = 105,
                 Name = "Dubnio",
                 Symbol = "Db",
                 AtomicMass = 262,
                 Electronegativity = "-",
                 ControlName = "btnDubnio",
                 Group = 5,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 106,
                 Name = "Seaborgio",
                 Symbol = "Sg",
                 AtomicMass = 263,
                 Electronegativity = "-",
                 ControlName = "btnSeaborgio",
                 Group = 6,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 107,
                 Name = "Bohrio",
                 Symbol = "Bh",
                 AtomicMass = 262,
                 Electronegativity = "-",
                 ControlName = "btnBohrio",
                 Group = 7,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 108,
                 Name = "Hassio",
                 Symbol = "Hs",
                 AtomicMass = 265,
                 Electronegativity = "-",
                 ControlName = "btnHassio",
                 Group = 8,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 109,
                 Name = "Meitnerio",
                 Symbol = "Mt",
                 AtomicMass = 266,
                 Electronegativity = "-",
                 ControlName = "btnMeitnerio",
                 Group = 9,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 110,
                 Name = "Ununilio",
                 Symbol = "Uun",
                 AtomicMass = 269,
                 Electronegativity = "-",
                 ControlName = "btnUnunilio",
                 Group = 10,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 111,
                 Name = "Unununio",
                 Symbol = "Uuu",
                 AtomicMass = 272,
                 Electronegativity = "-",
                 ControlName = "btnUnununio",
                 Group = 11,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 112,
                 Name = "Ununbio",
                 Symbol = "Uub",
                 AtomicMass = 277,
                 Electronegativity = "-",
                 ControlName = "btnUnunbio",
                 Group = 12,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 113,
                 Name = "Ununtrio",
                 Symbol = "Uut",
                 AtomicMass = 0,
                 Electronegativity = "-",
                 ControlName = "btnUnuntrio",
                 Group = 13,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 114,
                 Name = "Ununquadio",
                 Symbol = "Uuq",
                 AtomicMass = 289,
                 Electronegativity = "-",
                 ControlName = "btnUnunquadio",
                 Group = 14,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 115,
                 Name = "Ununpentio",
                 Symbol = "Uup",
                 AtomicMass = 0,
                 Electronegativity = "-",
                 ControlName = "btnUnunpentio",
                 Group = 15,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 116,
                 Name = "Ununhexio",
                 Symbol = "Uuh",
                 AtomicMass = 289,
                 Electronegativity = "-",
                 ControlName = "btnUnunhexio",
                 Group = 16,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 117,
                 Name = "Ununseptio",
                 Symbol = "Uus",
                 AtomicMass = 0,
                 Electronegativity = "-",
                 ControlName = "btnUnunseptio",
                 Group = 17,
                 Period = 7
             }
             );
            AllElements.Add(
             new Element
             {
                 AtomicNumber = 118,
                 Name = "Ununoctio",
                 Symbol = "Uu0",
                 AtomicMass = 293,
                 Electronegativity = "-",
                 ControlName = "btnUnunoctio",
                 Group = 18,
                 Period = 7
             }
             );

            return AllElements;

        }
    }
}
