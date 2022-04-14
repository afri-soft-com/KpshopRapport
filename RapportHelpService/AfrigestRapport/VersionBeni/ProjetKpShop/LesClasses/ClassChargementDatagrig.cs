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
    class ClassChargementDatagrig
    {
        public DataTable tableEmoir;

        public void chargmentTable(string s, string para)
        {

            try
            {


//                string s = " SELECT        tClientEmb.CodeClient, tClientEmb.Cleint, tCategorieEmbalage.DesignationCatClirntEmb " +
//" FROM tClientEmb INNER JOIN " +
//                        " tCategorieEmbalage ON tClientEmb.CatClientEmbal = tCategorieEmbalage.CatClientEmbal " +
//"   WHERE (tClientEmb.CatClientEmbal=@a)  ORDER BY tClientEmb.Num DESC  ";



                //WHERE  CategorieChambre =1  ORDER BY  CodeSeviceHosp 


                ClassRequette classeReq = new ClassRequette();
                // ClassRequette classeReq2 = new ClassRequette();
                // ClassRequette classeReq3 = new ClassRequette();
                // ClassRequette classeReq4 = new ClassRequette();

                string[] r = { para, "0" };


                classeReq.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tOption2", r);

                // classeReq2.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tclienEMB", r);
                // classeReq3.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm2", r);
                // classeReq4.chargementAvecLesParametre(s, ClassVaribleGolbal.seteconnexion, "tcilentenm3", r);




                tableEmoir = classeReq.dt;


                // TableComboDest = classeReq2.dt;
                // TableCompoPro = classeReq3.dt;
                // tableComboVerification = classeReq4.dt;
                // CbChambre =;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void chargmentTableDateAvecParametre(string s, string[] r, DateTime[] da)
        {

            try
            {


                ClassRequette classeReq = new ClassRequette();
               

               // string[] r = { para, "0" };
               // DateTime[] da = { date1, date2 };


                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, da);

            


                tableEmoir = classeReq.dt;


               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void chargmentTableDate(string s, string para, DateTime date1, DateTime date2)
        {

            try
            {







                ClassRequette classeReq = new ClassRequette();


                string[] r = { para, "0" };
                DateTime[] da = { date1, date2 };


                classeReq.chargementAvecLesParametreDate(s, ClassVaribleGolbal.seteconnexion, "tOption2", r, da);





                tableEmoir = classeReq.dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }
   
   
}
