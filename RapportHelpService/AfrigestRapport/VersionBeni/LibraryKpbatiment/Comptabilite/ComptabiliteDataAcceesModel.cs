using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LibraryKpbatiment.Operations;
using LibraryKpbatiment.MvtCompte;

namespace ClassLibrary.Comptabilite
{
   public class ComptabiliteDataAcceesModel
    {
        public int NouvelleOperation(OperationComptableModel objectOP)
        {
            OperationDataAccessLayer op = new OperationDataAccessLayer();
           OperationModel modeOp = new OperationModel();
            //  modeOp.Reference = tbl.Reference;
           // modeOp.RefCas = objectOP.RefCas;
            modeOp.Libelle = objectOP.Libelle;
          //  modeOp.CodeEleve = objectOP.CodeEleve;
          //  modeOp.CodeLibele = objectOP.CodeLibele;
           modeOp.NumOperation = objectOP.NumOperation;
            modeOp.DateOp = objectOP.DateOp;
            modeOp.DateSysteme = objectOP.DateSysteme;
            modeOp.NomUt = objectOP.NomUt;
            //  modeOp.
            // modeOp.status_result = tbl.status_result;
            //modeOp.status_response = tbl.status_response;

            OperationModel modeOpApasse = new OperationModel();

            modeOpApasse = op.EnregistrerOperationAuto(modeOp);
            int Result=0;
            if (modeOpApasse.status_result == 1)
            {

                MvtCompteDataAccessLayer mvtOp = new MvtCompteDataAccessLayer();
               MvtCompteModel tmvtDebit = new MvtCompteModel();
               MvtCompteModel tmvtCredit = new MvtCompteModel();

                tmvtDebit.NumCompte = objectOP.NumCompteDebitEntree;
                tmvtDebit.Entree = objectOP.Montant;
                tmvtDebit.Details = objectOP.Libelle;
              //  tmvtDebit.CodeLibele = "ok";
                tmvtDebit.Sortie = 0;
                tmvtDebit.Qte = 1;
                tmvtDebit.NumOperation = modeOpApasse.NumOperation;
                //  tmvtDebit.DateMvt = modeOp.DateOp;
                //  tmvtDebit.Interet = 0;

                tmvtCredit.NumCompte = objectOP.NumCompteCreditSortie;
                tmvtCredit.Entree = 0;
                tmvtCredit.Qte = 1;
                tmvtCredit.Details = objectOP.Libelle;
                tmvtCredit.Sortie = objectOP.Montant;
                tmvtCredit.NumOperation = modeOpApasse.NumOperation;
              //  tmvtCredit.CodeLibele = "ok";
                // tmvtCredit.DateMvt = modeOp.DateOp;
                // tmvtCredit.Interet = 0;



             Result = mvtOp.AjouterMvtCompte(tmvtCredit);
                int Result2 = mvtOp.AjouterMvtCompte(tmvtDebit);


            }

           // return modeOpApasse.status_result;
            return Result;
        }



    }
}
