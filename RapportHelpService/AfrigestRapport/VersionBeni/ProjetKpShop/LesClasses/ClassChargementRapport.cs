using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1;
using System.Windows.Forms;

namespace GoldenStarApplication.LesClasses
{

    class ClassChargementRapport
    {

       // public DataTable tableRapport;
        public void afficherPV(string codePv )
        {
            string sPro2 = "ProRapportPV";
           DataTable tablePlan;
            string chiminRap = "Rapport/ReportPlant.rdlc";
            string[] parametre = { codePv, "641" };
            DateTime[] d = { DateTime.Now };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }


        public void afficherfactures(string codePv)
        {
            string sPro2 = "ProFactureSelonPV";
            DataTable tablePlan;
            string chiminRap = "Rapport/ReportFacture.rdlc";
            string[] parametre = { codePv, "641" };
            DateTime[] d = { DateTime.Now };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }
        public void afficherTousLesPv(string codeVihicule, string sPro2, DateTime d1, DateTime d2,string chiminRap)
        {
            //string sPro2 = "ProTousLesPvParVh";
            DataTable tablePlan;
          //  string chiminRap = "Rapport/ReportToutPvDeVih.rdlc";
            string[] parametre = { codeVihicule,"ClassVaribleGolbal.GroupeCompteChargePv "};
            DateTime[] d = {  d1, d2 };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
             FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }

        public void afficherTousLesOT(string codeVihicule, string sPro2, DateTime d1, DateTime d2,string chiminRap)
        {
           // string sPro2 = "ProTousLesOtParVh";
            DataTable tablePlan;
            //string chiminRap = "Rapport/ReportToutOt.rdlc";
            string[] parametre = { codeVihicule, "ClassVaribleGolbal.GroupeCompteChargeOT" };
            DateTime[] d = { d1, d2 };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }

        public void afficherOT(string codOte)
        {
            string sPro2 = "ProOrdeDeTravail";
            DataTable tablePlan;
            string chiminRap = "Rapport/ReportOdreDeTravail.rdlc";
            string[] parametre = { codOte,""};
            DateTime[] d = { DateTime.Now };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();




        }

        public void affichetOUUrAPPOR(string sPro2, string chiminRap, string[] parametre, DateTime[] d)
        {
           // string sPro2 = "ProOrdeDeTravail";
            DataTable tablePlan;
           // string chiminRap = "Rapport/ReportOdreDeTravail.rdlc";
           // string[] parametre = { codOte, ClassVaribleGolbal.GroupeCompteChargeOT };
           // DateTime[] d = { DateTime.Now };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
           FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.Show();
            //fo.Focus();


        }

        public void affichetOUUrAPPORavecDeux(string sPro1, string sPro2, string chiminRap, string[] parametre, DateTime[] d)
        {
            
            DataTable tablePlan;
            DataTable tablePlan2;

            ClassRequette classeReq = new ClassRequette();
            classeReq.chargementAvecLesParametreDateStorage(sPro1, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq.dt;

            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan2 = classeReq2.dt;

            FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");
            fo.chargemenentRapporteAveVDataSetPro(tablePlan2, chiminRap, "DataSet2");

            fo.ShowDialog();
            //fo.Focus();


        }



        public void afficherPVproduction(string codePv)
        {
            string sPro2 = "ProRapportPV";
            string sPro3 = "ProProductionPV";
            DataTable tablePlan, tablePlanPro;
            string chiminRap = "Rapport/ReportPruiduitPv.rdlc";
            string[] parametre = { codePv };
            DateTime[] d = { DateTime.Now };

            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;

            ClassRequette classeReq3 = new ClassRequette();
            classeReq3.chargementAvecLesParametreDateStorage(sPro3, ClassVaribleGolbal.seteconnexion, "tOption", parametre, d);
            tablePlanPro = classeReq3.dt;

             FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");
            fo.chargemenentRapporteAveVDataSetPro(tablePlanPro, chiminRap, "DataSet2");

            fo.ShowDialog();
            //fo.Focus();


        }
        public void ModdifierDateINI(DateTime date2)
        {
            string s = " UPDATE       tOperation  SET                DateOp = @da" +
                    " WHERE        (NumOperation = @a) ";




            string[] r = { ClassVaribleGolbal.OPinit };


            DateTime[] d = { date2 };

            ClassRequette req = new ClassRequette();

            req.ExecuterSqlAvecDate(ClassVaribleGolbal.seteconnexion, s, r, d);

        }

        public void afficherbILANT(string chiminRap,DateTime d1,DateTime d2, string sPro2)
        {
           // string sPro2 = "ProBilanVihicule";
            DataTable tablePlan;
            //string chiminRap = "Rapport/ReportBilanVehicule.rdlc";
            string[] parametre = { ""};
            DateTime[] d = { d1, d2 };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption4", parametre, d);
            tablePlan = classeReq2.dt;
             FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }

        public void afficherbILANTparVH(string chiminRap, string sPro2, string CodeVehicule, DateTime d1, DateTime d2)
        {
           // string sPro2 = "ProBilanVihiculeParVH";
            DataTable tablePlan;
            //string chiminRap = "Rapport/ReportBilanVehicule.rdlc";
            string[] parametre = { CodeVehicule };
            DateTime[] d = { d1, d2 };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption5", parametre, d);
            tablePlan = classeReq2.dt;
              FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }


        public void afficherReleveClient(string chiminRap, string sPro2, string Compte, DateTime d1, DateTime d2)
        {
            // string sPro2 = "ProBilanVihiculeParVH";
            DataTable tablePlan;
            //string chiminRap = "Rapport/ReportBilanVehicule.rdlc";
            string[] parametre = { Compte };
            DateTime[] d = { d1, d2 };
            ClassRequette classeReq2 = new ClassRequette();
            classeReq2.chargementAvecLesParametreDateStorage(sPro2, ClassVaribleGolbal.seteconnexion, "tOption5", parametre, d);
            tablePlan = classeReq2.dt;
             FormEtat fo = new FormEtat();
            fo.chargemenentRapporteAveVDataSetPro(tablePlan, chiminRap, "DataSet1");

            fo.ShowDialog();
            //fo.Focus();


        }


    }
}
