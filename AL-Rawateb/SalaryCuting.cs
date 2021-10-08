using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace AL_Rawateb
{
    class SalaryCuting
    {
        Myconnection mycon;

        public SalaryCuting()
        {
            this.mycon = new Myconnection(Application.StartupPath + "\\rwateb.mdf;");
        }

        public void do_calc(string idemp, string month, string year)
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /// قطع دقعات من جداول الحسميات والأقساط والقروض
            cutTheDaf3at(idemp, month, year);
            ///++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            DataTable dtemployees = mycon.myselect_ds("select * from Employees where id=" + idemp);
            DataRow employee = dtemployees.Rows[0];
            int stopsal = (int)employee["stopsal"];
            if (stopsal == 0)
            {
                string id = employee["id"].ToString().Trim();
                string zati = employee["zati"].ToString().Trim();
                string name = employee["fname"].ToString().Trim() + " " + employee["father"].ToString().Trim() + " " + employee["lname"].ToString().Trim();
                string visacard = employee["visacard"].ToString().Trim();
                int salarycut = Convert.ToInt32(employee["salarycut"].ToString());
                string usingsubject = employee["usersubject"].ToString();

                /////التامينات
                string savingsystm = employee["savingsystem"].ToString().Trim();
                string savingejtmaeah = "0";
                string savingemployee = "0";
                string savingUser = "0";
                int savingtotal = 0;
                if (savingsystm.Trim() == "ت اجتماعية")//ت اجتماعية ت موظف  ت مستخدم
                {
                    int d = salarycut * 7 / 100;
                    savingtotal += d;
                    savingejtmaeah = d.ToString();
                }
                else if (savingsystm.Trim() == "ت موظف")//ت اجتماعية ت موظف  ت مستخدم
                {
                    int d = salarycut * 7 / 100;
                    savingtotal += d;
                    savingemployee = d.ToString();
                }
                else//ت اجتماعية ت موظف  ت مستخدم
                {
                    int d = salarycut * 7 / 100;
                    savingtotal += d;
                    savingUser = d.ToString();
                }

                //-----------------------------------------------------------------------------
                DataTable dttawed = mycon.myselect_ds("select * from Tawed where idemployee=" + id + "");
                int familytawed = 0;
                int forokattawed = 0;
                int tawedekhtesas = 0;
                int tawedtabeah = 0;
                int tawedmasol = 0;
                float nesptektsas = 0;
                float nespttabea = 0;
                int dareptekhtesas = 0;
                int darepttabea = 0;
                int dareptmasol = 0;

                if (dttawed.Rows.Count > 0)
                {
                    int stopektsas = Convert.ToInt32(mycon.getonevalue("select stopektsas from Options where id=1"));
                    if (stopektsas == 0)
                    {
                        tawedekhtesas = (int)Math.Round(float.Parse(dttawed.Rows[0]["tawedekhtesas"].ToString()) * salarycut / 100);
                        dareptekhtesas = collect_darept_TawedTabeah(salarycut, tawedekhtesas);
                        nesptektsas = float.Parse(dttawed.Rows[0]["tawedekhtesas"].ToString());
                    }

                    int stoptabea = Convert.ToInt32(mycon.getonevalue("select stoptabea from Options where id=1"));
                    if (stoptabea == 0)
                    {
                        tawedtabeah = (int)Math.Round(float.Parse(dttawed.Rows[0]["tawedtabeah"].ToString()) * salarycut / 100);
                        darepttabea = collect_darept_TawedTabeah(salarycut, tawedtabeah);
                        nespttabea = float.Parse(dttawed.Rows[0]["tawedtabeah"].ToString());
                    }

                    int stopmasol = Convert.ToInt32(mycon.getonevalue("select stopmasol from Options where id=1"));
                    if (stopmasol == 0)
                    {
                        tawedmasol = (int)dttawed.Rows[0]["tawedmasol"];
                        dareptmasol = collect_darept_TawedTabeah(salarycut, tawedmasol);
                    }

                    familytawed = 0;
                    if (dttawed.Rows[0]["child1"].ToString().Trim() == "1")
                        familytawed += 200;
                    if (dttawed.Rows[0]["child2"].ToString().Trim() == "1")
                        familytawed += 150;
                    if (dttawed.Rows[0]["child3"].ToString().Trim() == "1")
                        familytawed += 100;
                    if (dttawed.Rows[0]["wife"].ToString().Trim() == "1")
                        familytawed += 300;
                    familytawed += Convert.ToInt32(dttawed.Rows[0]["numberchild"].ToString()) * 25;
                    forokattawed = Convert.ToInt32(dttawed.Rows[0]["forokat"].ToString());
                }

                int total1 = familytawed + salarycut + forokattawed;
                int totaltawed = total1 + tawedekhtesas + tawedmasol + tawedtabeah - dareptekhtesas - dareptmasol - darepttabea;

                //-----------------------------------------------------------------------------
                DataTable dthasmcut = mycon.myselect_ds("select * from Hasmcut where idemployee=" + id + "");
                //int dareptdakhl = 0;

                int sakanomali = 0;
                int jeshtahrer = 0;
                int tabeaamali = 0;
                int tabeamali = 0;
                int nakaptmohands = 0;
                int nakaptzerai = 0;
                int nakaptomalentfa = 0;
                int nakaptomaleshtrak = 0;
                int omal = 0;
                int forokathasm = 0;
                int majlesmadeneh = 0;
                int motkaed = 0;
                int nakaptamalishare1 = 0;
                int nakaptamalishare2 = 0;

                if (dthasmcut.Rows.Count > 0)
                {
                    sakanomali = Convert.ToInt32(dthasmcut.Rows[0]["estemartamali"].ToString());
                    jeshtahrer = Convert.ToInt32(dthasmcut.Rows[0]["jeshtahrer"].ToString());
                    forokathasm = Convert.ToInt32(dthasmcut.Rows[0]["frokat"].ToString());
                    majlesmadeneh = Convert.ToInt32(dthasmcut.Rows[0]["estemartbaladi"].ToString());

                    tabeaamali = Convert.ToInt32(dthasmcut.Rows[0]["tabeaamali"].ToString());
                    nakaptzerai = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptzerai"].ToString()) * salarycut / 100));
                    nakaptmohands = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptmohands"].ToString()) * salarycut / 100));

                    if (Convert.ToDouble(dthasmcut.Rows[0]["nakaptentefa"].ToString()) != 0)
                    {
                        nakaptomalentfa = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptentefa"].ToString()) * salarycut / 100));
                    }

                    if (Convert.ToDouble(dthasmcut.Rows[0]["nakaptamalishare"].ToString()) != 0)
                    {
                        motkaed = Convert.ToInt32(mycon.getonevalue("select motkaedCount from Options where id=1")) * 15;
                        nakaptamalishare1 = Convert.ToInt32(mycon.getonevalue("select omaleshtrak1 from Options where id=1"));
                        nakaptamalishare2 = Convert.ToInt32(mycon.getonevalue("select omaleshtrak2 from Options where id=1"));
                        nakaptomaleshtrak = Convert.ToInt32(Math.Round(Convert.ToDouble(dthasmcut.Rows[0]["nakaptamalishare"].ToString()) * salarycut / 100));
                    }
                    omal = nakaptomalentfa + nakaptomaleshtrak + nakaptamalishare1 + nakaptamalishare2 + motkaed;
                }

                //--------------------------------------------------------------
                string ejaza = "0";
                string sehea = "0";
                string okoba = "0";
                string ress3 = mycon.getonevalue("select total from Okobaejaza where idemployee=" + id + " and year=" + year + " and month=" + month + " and type like '%ejaza%'  ");
                if (ress3 != "no")
                    ejaza = ress3;

                string ress4 = mycon.getonevalue("select total from Okobaejaza where idemployee=" + id + " and year=" + year + " and month=" + month + " and type like '%sehea%'  ");
                if (ress4 != "no")
                    sehea = ress4;

                string ress2 = mycon.getonevalue("Select value1 from Okobapay where idemployee=" + id + " and year=" + year + " and month=" + month + "");
                if (ress2 != "no")
                {
                    okoba = ress2;
                }
                //---------------------------------------------------------------
                string kardakari = "0";
                string q = "select Payloan.payvalue from Payloan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and Payloan.idemployee=" + id + " and Payloan.idloan=Loan.id and typeloan like '%kardakari%' ";
                string res = mycon.getonevalue(q);
                if (res != "no")
                    kardakari = res;

                string taslefshabi = "0";
                q = "select Payloan.payvalue from Payloan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and Payloan.idemployee=" + id + " and Payloan.idloan=Loan.id and typeloan like '%taslefshabi%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    taslefshabi = res;

                string toferbareed = "0";
                q = "select Payloan.payvalue from Payloan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and Payloan.idemployee=" + id + " and Payloan.idloan=Loan.id and typeloan like '%toferbareed%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    toferbareed = res;

                string sulfa = "0";
                q = "select Payloan.payvalue from Payloan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and Payloan.idemployee=" + id + " and Payloan.idloan=Loan.id and typeloan like '%sulfa%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    sulfa = res;

                //////////
                string karednakaba = "0";
                q = "select PayLoan.payvalue from PayLoan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and Payloan.idemployee=" + id + " and PayLoan.idloan=Loan.id and typeloan like '%kardnakaba%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    karednakaba = res;
                /////
                string karedtjare = "0";
                q = "select PayLoan.payvalue from PayLoan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and PayLoan.idemployee=" + id + " and PayLoan.idloan=Loan.id and typeloan like '%tejary%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    karedtjare = res;

                //////////
                string karedzawaj = "0";
                q = "select PayLoan.payvalue from PayLoan,Loan where paymonth=" + month + " and payyear=" + year + " " +
                           " and PayLoan.idemployee=" + id + " and Paykest.idloan=Loan.id and typeloan like '%zwaj%' ";
                res = mycon.getonevalue(q);
                if (res != "no")
                    karedzawaj = res;

                //------------------------------------------------------------------
                string thema = "0";
                string q1 = "SELECT Hasmpay.payvalue FROM Hasmpay INNER JOIN " +
                            "Hasmeat ON Hasmpay.idhasm = Hasmeat.id " +
                            "WHERE (Hasmpay.paymonth = " + month + ") AND (Hasmpay.payyear = " + year + ") AND (Hasmpay.idemployee = " + id + ") AND (Hasmeat.typehasm LIKE '%thema%')";
                string res11 = mycon.getonevalue(q1);
                if (res11 != "no")
                    thema = res11;
                //MessageBox.Show(thema);
                string khedma = "0";
                q1 = "SELECT Hasmpay.payvalue FROM Hasmpay INNER JOIN " +
                     "Hasmeat ON Hasmpay.idhasm = Hasmeat.id " +
                     "WHERE (Hasmpay.paymonth = " + month + ") AND (Hasmpay.payyear = " + year + ") AND (Hasmpay.idemployee = " + id + ") AND (Hasmeat.typehasm LIKE '%khedma%')";
                res11 = mycon.getonevalue(q1);
                if (res11 != "no")
                    khedma = res11;
                //MessageBox.Show(khedma);
                string tanfiz = "0";
                q1 = "SELECT Hasmpay.payvalue FROM Hasmpay INNER JOIN " +
                     "Hasmeat ON Hasmpay.idhasm = Hasmeat.id " +
                     "WHERE (Hasmpay.paymonth = " + month + ") AND (Hasmpay.payyear = " + year + ") AND (Hasmpay.idemployee = " + id + ") AND (Hasmeat.typehasm LIKE '%tanfiz%')";
                res11 = mycon.getonevalue(q1);
                if (res11 != "no")
                    tanfiz = res11;


                //---------------------------------------------------------------------
                string salttajzea = "0";
                string q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%salttajzea%' ";
                string res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    salttajzea = res12;

                string saltsndos = "0";
                q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%saltsndos%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    saltsndos = res12;

                string esthlake = "0";
                q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%jameaesthlaki%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    esthlake = res12;
                ////////
                string sharktajzea = "0";
                q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%wahdaershadia%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    sharktajzea = res12;
                /////////
                string estemlakbal = "0";
                q2 = "select payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%estmlakbaladia%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    estemlakbal = res12;

                string jameasakania = "0";
                q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%jameasakania%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    jameasakania = res12;

                string otherhasmeat = "0";
                q2 = "select Paykest.payvalue from Paykest,Kest where paymonth=" + month + " and payyear=" + year + " " +
                           " and Paykest.idemployee=" + id + " and Paykest.idkest=Kest.id and typekest like '%otherhasmeat%' ";
                res12 = mycon.getonevalue(q2);
                if (res12 != "no")
                    otherhasmeat = res12;

                //--------------------------------------------------------------------------------------------
                int dareptdakhl = collect_dareptdakhl(salarycut + familytawed + forokattawed - savingtotal - int.Parse(khedma));

                int totalhasem = dareptdakhl + int.Parse(sehea) + int.Parse(okoba) + int.Parse(ejaza)
                    + nakaptmohands + nakaptzerai + int.Parse(thema) + savingtotal + int.Parse(tanfiz) + int.Parse(khedma) +
                    majlesmadeneh + jeshtahrer + tabeaamali + tabeamali + omal;


                int totalkared = int.Parse(taslefshabi) + int.Parse(sulfa) + int.Parse(kardakari) + int.Parse(toferbareed) +
                                int.Parse(karedtjare) + int.Parse(karednakaba) + int.Parse(karedzawaj);

                int totalaksat = int.Parse(jameasakania) + int.Parse(saltsndos) + int.Parse(sharktajzea) +
                                 int.Parse(esthlake) + int.Parse(salttajzea) + int.Parse(estemlakbal);

                int totalwhithouttawed = total1 - totalhasem - totalkared - totalaksat - int.Parse(otherhasmeat);
                int total = totaltawed - totalhasem - totalkared - totalaksat - int.Parse(otherhasmeat);

                string chek = mycon.getonevalue("SELECT id FROM salarys WHERE id=" + id + "AND month=" + month + " AND year=" + year + " ");
                if (chek == "no")
                {
                    mycon.Commoand("insert into salarys ( id, zati , name, visacard, salarycut , usingsubject , savingejtma , savingemployee , savinguser , " +
                                    "family , ektesas, darepaektesas , nesptektsas ," +
                                    "tabeaamal, darepatapea, nespttapea , maseolea, darepamaseolea , forokattawed , total1, totaltawed ," +
                                    "darepadakel, sakanomali , madena , tahrer , tabeamali, tabeaamali, forokathasm , nakabtmohands , " +
                                    "nakabazeraee , omalentfa, omaleshtrak ,tkafol, mosaeda, tdamon , omal, " +
                                    "thema , kedma , tanfiz , okoba , ejaza , seha , totalhasem ," +
                                    "kardakare , taslef , tawfer , nakaba , tejare , zawaj , solfa, totalkared ," +
                                    "salttajze , sharkttajzea , esthlake, sondos , sakan , estmlakbalade , totalaksat ," +
                                    "otherhasem ,total, lastsalary , month, year ) values " +
                                    "(" + id + "," + zati + ",'" + name + "','" + visacard + "'," + salarycut + ",'" + usingsubject + "'," + savingejtmaeah + "," + savingemployee + "," + savingUser +
                                    "," + familytawed + "," + tawedekhtesas + "," + dareptekhtesas + "," + nesptektsas +
                                    "," + tawedtabeah + "," + darepttabea + "," + nespttabea + "," + tawedmasol + "," + dareptmasol + "," + forokattawed + "," + total1 + "," + totaltawed +
                                    "," + dareptdakhl + "," + sakanomali + "," + majlesmadeneh + "," + jeshtahrer + "," + tabeamali + "," + tabeaamali + "," + forokathasm + "," + nakaptmohands +
                                    "," + nakaptzerai + "," + nakaptomalentfa + " ," + nakaptomaleshtrak + "," + nakaptamalishare1 + "," + nakaptamalishare2 + "," + motkaed + "," + omal +
                                    "," + thema + "," + khedma + "," + tanfiz + "," + okoba + "," + ejaza + "," + sehea + "," + totalhasem +
                                    "," + kardakari + "," + taslefshabi + "," + toferbareed + "," + karednakaba + "," + karedtjare + "," + karedzawaj + "," + sulfa + "," + totalkared +
                                    "," + salttajzea + "," + sharktajzea + "," + esthlake + "," + saltsndos + "," + jameasakania + "," + estemlakbal + "," + totalaksat +
                                    "," + otherhasmeat + "," + totalwhithouttawed + "," + total + "," + month + "," + year + ")");
                }
                else
                {
                    mycon.Commoand("update salarys set zati=" + zati + ",name='" + name + "',visacard='" + visacard + "',salarycut=" + salarycut + ",usingsubject='" + usingsubject.Trim() + "',savingejtma = " + savingejtmaeah.Trim() + ",savingemployee=" + savingemployee.Trim() + ",savinguser=" + savingUser.Trim() +
                                    ",family=" + familytawed + ",ektesas=" + tawedekhtesas + ",darepaektesas=" + dareptekhtesas + ",nesptektsas=" + nesptektsas +
                                    ",tabeaamal=" + tawedtabeah + ",darepatapea=" + darepttabea + ",nespttapea=" + nespttabea + ",maseolea=" + tawedmasol + ",darepamaseolea=" + dareptmasol +
                                    ",forokattawed=" + forokattawed + ",total1=" + total1 + ",totaltawed=" + totaltawed +
                                    ",darepadakel=" + dareptdakhl + ",sakanomali=" + sakanomali + ",madena=" + majlesmadeneh + ",tahrer=" + jeshtahrer + ",tabeamali=" + tabeamali + ",tabeaamali=" + tabeaamali +
                                    ",forokathasm=" + forokathasm + ",nakabtmohands=" + nakaptmohands + ",nakabazeraee=" + nakaptzerai +
                                    ",omalentfa = " + nakaptomalentfa + " , omaleshtrak = " + nakaptomaleshtrak + ", tkafol = " + nakaptamalishare1 + ", mosaeda =" + nakaptamalishare2 + ", tdamon = " + motkaed + ", omal=" + omal +
                                    ",thema=" + thema + ",kedma=" + khedma + ",tanfiz=" + tanfiz + ",okoba=" + okoba + ",ejaza=" + ejaza + ",seha=" + sehea + ",totalhasem=" + totalhasem +
                                    ",kardakare=" + kardakari + ",taslef=" + taslefshabi + ",tawfer=" + toferbareed + ",nakaba=" + karednakaba + ",tejare=" + karedtjare + ",zawaj=" + karedzawaj + ",solfa=" + sulfa +
                                    ",totalkared=" + totalkared + ",salttajze=" + salttajzea + ",sharkttajzea=" + sharktajzea + ",esthlake = " + esthlake + ",sondos=" + saltsndos + ",sakan=" + jameasakania + ",estmlakbalade=" + estemlakbal +
                                    ",totalaksat=" + totalaksat + ",otherhasem=" + otherhasmeat + ",total=" + totalwhithouttawed + ",lastsalary=" + total + " WHERE id=" + chek + "AND month = "+ month +" AND year="+ year);
                }
            }
            else
            {
                mycon.Commoand("delete from salarys where id=" + idemp + "AND month=" + month + " AND year=" + year + " ");
            }
        }


        // توابع حساب ضريبة تعويض الاختصاص وضريبة طبيعة العمل والمسؤولية
        private int collect_darept_TawedTabeah(int sal, int tabeah)
        {
            try
            {
                int sal_tabeah = sal + tabeah;
                double darept = 0;
                double darept1 = 0;
                double darept2 = 0;
                int newsalafterminus = sal_tabeah;

                int max_percent_befor = get_max_percent_cut_shareha(sal);
                int max_percent_after = get_max_percent_cut_shareha(sal_tabeah);
                int sharehaSalary = get_p1_of_max_limit_shareha(sal);//part1_of_max_sharehaSalary
                int part1 = 0;
                int part2 = 0;
                int result = 0;
                if (max_percent_befor == max_percent_after)
                {
                    darept = tabeah * max_percent_after / 100;
                    result = (int)Math.Ceiling(tabeah - darept);
                }
                else
                {
                    part1 = sal_tabeah - sharehaSalary;
                    part2 = tabeah - part1;
                    darept1 = tabeah * max_percent_after / 100;
                    darept2 = tabeah * max_percent_befor / 100;
                    result = (int)Math.Ceiling(tabeah - (darept1 + darept2));
                }
                int totaldarepa = Convert.ToInt32(darept + darept1 + darept2);
                string count = "0";
                return result;
            }
            catch (Exception eddd)
            {
                //MessageBox.Show(eddd.Message);
                return 0;
            }
        }
        private int get_max_percent_cut_shareha(int salarycuting)
        {
            if (salarycuting > 38000 && salarycuting <= 50000) { return 19; }
            if (salarycuting > 30000 && salarycuting <= 38000) { return 13; }
            if (salarycuting > 25000 && salarycuting <= 30000) { return 11; }
            if (salarycuting > 20000 && salarycuting <= 25000) { return 9; }
            if (salarycuting > 15000 && salarycuting <= 20000) { return 7; }
            if (salarycuting > 10000 && salarycuting <= 15000) { return 5; }
            else { return 0; }
        }
        private int get_p1_of_max_limit_shareha(int salarycuting)
        {
            if (salarycuting > 38000 && salarycuting <= 50000) { return 38000; }
            if (salarycuting > 30000 && salarycuting <= 38000) { return 30000; }
            if (salarycuting > 25000 && salarycuting <= 30000) { return 25000; }
            if (salarycuting > 20000 && salarycuting <= 25000) { return 20000; }
            if (salarycuting > 15000 && salarycuting <= 20000) { return 15000; }
            if (salarycuting > 10000 && salarycuting <= 15000) { return 10000; }
            else { return salarycuting; }
        }



        private int collect_dareptdakhl(int sal)
        {
            try
            {
                double dareptdakhl = 0;
                int newsalafterminus = sal;

                if (newsalafterminus > 38000 && newsalafterminus <= 50000)
                {
                    dareptdakhl += (sal - 38000) * 19 / 100;
                    newsalafterminus = 38000;
                }
                if (newsalafterminus > 30000 && newsalafterminus <= 38000)
                {
                    dareptdakhl += (newsalafterminus - 30000) * 13 / 100;
                    newsalafterminus = 30000;
                }
                if (newsalafterminus > 25000 && newsalafterminus <= 30000)
                {
                    dareptdakhl += (newsalafterminus - 25000) * 11 / 100;
                    newsalafterminus = 25000;
                }
                if (newsalafterminus > 20000 && newsalafterminus <= 25000)
                {
                    dareptdakhl += (newsalafterminus - 20000) * 9 / 100;
                    newsalafterminus = 20000;
                }
                if (newsalafterminus > 15000 && newsalafterminus <= 20000)
                {
                    dareptdakhl += (newsalafterminus - 15000) * 7 / 100;
                    newsalafterminus = 15000;
                }
                if (newsalafterminus > 10000 && newsalafterminus <= 15000)
                {
                    dareptdakhl += (newsalafterminus - 10000) * 5 / 100;
                    newsalafterminus = 10000;
                }
                return (int)Math.Ceiling(dareptdakhl);
            }
            catch
            {
                MessageBox.Show("يوجد خلل في حساب ضريبة الدخل");
                return 0;
            }
        }


        private void cutTheDaf3at(string empid, string month, string year)
        {
            //Loan ===================================================================================================
            DataTable dtloan = mycon.myselect_ds("select id,payvalue,restvalue from Loan where finish=0 and idemployee=" + empid + " ");
            if (dtloan.Rows.Count > 0)
            {
                for (int i = 0; i < dtloan.Rows.Count; i++)
                {
                    string idloan = dtloan.Rows[i]["id"].ToString();
                    int payvalue = Convert.ToInt32(dtloan.Rows[i]["payvalue"].ToString());
                    int restvalue = Convert.ToInt32(dtloan.Rows[i]["restvalue"].ToString());


                    string res = mycon.getonevalue("select id from Payloan where paymonth=" + month + " and payyear=" + year + " and idloan=" + idloan + " ");
                    if (res == "no")
                    {

                        if (restvalue > payvalue)
                        {
                            mycon.Commoand("insert into Payloan(idloan,idemployee,payvalue,paymonth,payyear) " +
                                           " values (" + idloan + "," + empid + "," + payvalue + "," + month + "," + year + ") ");
                            int newrest = restvalue - payvalue;
                            mycon.Commoand("update Loan set restvalue=" + newrest + " where id=" + idloan + " ");
                        }
                        else
                        {
                            int newpayvalue = restvalue;
                            mycon.Commoand("insert into Payloan(idloan,idemployee,payvalue,paymonth,payyear) " +
                                 " values (" + idloan + "," + empid + "," + newpayvalue + "," + month + "," + year + ") ");
                            mycon.Commoand("update Loan set restvalue=0,finish=1 where id=" + idloan + " ");
                        }

                    }
                }//end for
            }//if count
            //MessageBox.Show(payvaluloan.ToString());

            //Kest ===================================================================================================
            DataTable dtkest = mycon.myselect_ds("select id,payvalue,restvalue from Kest where finish=0 and idemployee=" + empid + " ");
            if (dtkest.Rows.Count > 0)
            {
                for (int i = 0; i < dtkest.Rows.Count; i++)
                {
                    string idkest = dtkest.Rows[i]["id"].ToString();
                    int payvalue = Convert.ToInt32(dtkest.Rows[i]["payvalue"].ToString());
                    int restvalue = Convert.ToInt32(dtkest.Rows[i]["restvalue"].ToString());

                    string res = mycon.getonevalue("select id from Paykest where paymonth=" + month + " and payyear=" + year + " and idkest=" + idkest + " ");
                    if (res == "no")
                    {

                        if (restvalue > payvalue)
                        {
                            mycon.Commoand("insert into Paykest(idkest,idemployee,payvalue,paymonth,payyear) " +
                                           " values (" + idkest + "," + empid + "," + payvalue + "," + month + "," + year + ") ");
                            int newrest = restvalue - payvalue;
                            mycon.Commoand("update Kest set restvalue=" + newrest + " where id=" + idkest + " ");
                        }
                        else
                        {
                            int newpayvalue = restvalue;
                            mycon.Commoand("insert into Paykest(idkest,idemployee,payvalue,paymonth,payyear) " +
                                 " values (" + idkest + "," + empid + "," + newpayvalue + "," + month + "," + year + ") ");
                            //int newrest = 0;
                            mycon.Commoand("update Kest set restvalue=0,finish=1 where id=" + idkest + " ");
                        }

                    }
                }//end for
            }//if count
            //MessageBox.Show(payvalukest.ToString());

            //Hasmeat ===================================================================================================
            DataTable dthasm = mycon.myselect_ds("select id,payvalue,restvalue from Hasmeat where finish=0 and idemployee=" + empid + " ");
            if (dthasm.Rows.Count > 0)
            {
                for (int i = 0; i < dthasm.Rows.Count; i++)
                {
                    string idhasm = dthasm.Rows[i]["id"].ToString();
                    int payvalue = Convert.ToInt32(dthasm.Rows[i]["payvalue"].ToString());
                    int restvalue = Convert.ToInt32(dthasm.Rows[i]["restvalue"].ToString());

                    string q = "select id from Hasmpay where paymonth=" + month + " and payyear=" + year + " and idhasm=" + idhasm + " ";
                    string res = mycon.getonevalue(q);
                    if (res == "no")
                    {

                        if (restvalue > payvalue)
                        {
                            mycon.Commoand("insert into Hasmpay(idhasm,idemployee,payvalue,paymonth,payyear) " +
                                           " values (" + idhasm + "," + empid + "," + payvalue + "," + month + "," + year + ") ");
                            int newrest = restvalue - payvalue;
                            mycon.Commoand("update Hasmeat set restvalue=" + newrest + " where id=" + idhasm + " ");
                        }
                        else
                        {
                            int newpayvalue = restvalue;
                            mycon.Commoand("insert into Hasmpay(idhasm,idemployee,payvalue,paymonth,payyear) " +
                                 " values (" + idhasm + "," + empid + "," + newpayvalue + "," + month + "," + year + ") ");
                            //int newrest = 0;
                            mycon.Commoand("update Hasmeat set restvalue=0,finish=1 where id=" + idhasm + " ");
                        }
                    }
                }//end for
            }//if count
            //------------------------------------------------------------
            //okoba+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //PAYOkoba ++++++++++++
            DataTable dtokoba = mycon.myselect_ds("select * from Okobaejaza where idemployee=" + empid + " and stopedit=0 and type like '%okoba%' ");

            int yearnow = Convert.ToInt32(year);//
            int monthnow = Convert.ToInt32(month);//

            int yearokoba = yearnow;
            int monthokoba = monthnow;

            string idokoba = "";
            int total_inmonth = 0;
            int numbermonth = 0;
            int okoba = 0;

            if (dtokoba.Rows.Count > 0)
            {
                for (int i = 0; i < dtokoba.Rows.Count; i++)
                {
                    monthokoba = Convert.ToInt32(dtokoba.Rows[i]["month"].ToString());
                    yearokoba = Convert.ToInt32(dtokoba.Rows[i]["year"].ToString());

                    idokoba = dtokoba.Rows[i]["id"].ToString();

                    numbermonth = Convert.ToInt32(dtokoba.Rows[i]["daynumber"].ToString());//month number
                    total_inmonth = Convert.ToInt32(dtokoba.Rows[i]["total"].ToString());

                    string ress22 = mycon.getonevalue("Select count(id) from Okobapay where idokoba=" + idokoba + " and year=" + yearnow + " and month=" + monthnow + "");
                    if (ress22 != "0")//here there is pay already
                    {
                        //mycon.Commoand("update Okobapay set value1=" + total_inmonth + " where id=" + ress2 + "  ");
                        okoba += total_inmonth;////for total okoba
                        //mycon.Commoand("insert into Okobapay(idokoba,month,year,value1,idemployee) values(" + idokoba + "," + monthnow + "," + yearnow + "," + total_inmonth + "," + empid + " ) ");
                    }
                    else
                    {
                        string ress2 = mycon.getonevalue("Select count(id) from Okobapay where idokoba=" + idokoba + "");
                        int collect_number_month = (yearnow - yearokoba) * 12 + (monthnow - monthokoba);
                        if (collect_number_month >= 0)
                        {
                            if (int.Parse(ress2) < numbermonth)
                            {
                                okoba += total_inmonth;//for total okoba ejaza hasm
                                mycon.Commoand("insert into Okobapay(idokoba,month,year,value1,idemployee) values(" + idokoba + "," + monthnow + "," + yearnow + "," + total_inmonth + "," + empid + " ) ");
                            }
                            if (int.Parse(ress2) == numbermonth - 1)
                            {
                                mycon.Commoand("update Okobaejaza set stopedit=1 where id=" + idokoba + "");
                            }
                        }
                    }
                    //MessageBox.Show("Okoba: " + okoba.ToString());
                }//end for
            }//end if okoba.row>0
            //---------------------------------------------------------------------------------------------------------
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }
    }
}
