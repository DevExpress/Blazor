using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Reports.SwissQRCode {
    public class BillDS {
        public static BillInfo DataSource() {
            return new BillInfo() {
                BillDate = DateTime.Parse("2019.12.01"),
                BillNumber = "1598/7",
                Creditor = new PersonInfo() {
                    Address = "Museumstrasse 258\n2501 Biel",
                    Email = "h.schmid@schmid-workers.ch",
                    Website = "www.schmid-workers.ch",
                    Phone = "044 012 34 56",
                    Name = "Henri Schmid AG",
                    FullName = "Henri Schmid Service Switzerland AG"
                },
                Debtor = new PersonInfo() {
                    Address = "Breitenrain 857\nCH-2552 Orpund",
                    Name = "Ms. Rutschmann",
                    FullName = "Pia-Maria Rutschmann-Schnyder",
                    Phone = "",
                    Email = "",
                    Website = ""
                },
                QRBillData = new QRBillPaymentPartData() {
                    Account = "CH44 4499 5599 0008 99901",
                    AdditionalInformation = @"Order of 25.10.2019
##S1/01/20170309/11/10201409/20/14000000/22/36958/30/CH106017086/40/1020/41/3010",
                    ReferenceNumber = "21 0000 0000 3139 4004 3000 9017",
                    UltimateCreditor = @"Henri Schmid Service Switzerland AG
Museumstrasse 258
CH - 2501 Biel",
                    Creditor = @"Henri Schmid AG
Museumstrasse 258
CH - 2501 Biel",
                    Debtor = @"Pia-Maria Rutschmann-Schnyder
Breitenrain 857
CH-2552 Orpund",
                    DueDate = DateTime.Parse("2019.12.31"),
                    QRCodeData = @"SPC
0100
1
CH4444995599000899901
Henri Schmid AG
Museumstrasse
258
2501
Biel
CH
Henri Schmid Service Switzerland AG
Museumstrasse
258
2501
Biel
CH
8690
CHF
2019-12-31
Pia-Maria Rutschmann-Schnyder
Breitenrain
857
2552
Orpund
CH
QRR
210000000003139471430009017
Auftrag vom 25.10.2019##S1/01/20170309/11/10201409/20/14000/22/36958/30/CH10646546/40/1020/41/3010
UV1;1.1;1278564;1A-2F-43-AC-9B-33-21-B0-CC-D4-28-56;TCXVMKC22;2019-02-10T15:12:39; 2019-02-10T15:18:16
XY2;2a-2.2r;_R2-CH1_Conra1dCH-2074-1_3350_2019-03-13T10:23:47_16,919_0,00_0,00_0,00_0,00_+8FADt/DQ=_1==",
                    Currency = "CHF",
                    Amount = 8690,
                    Support = "Credit transfer"
                },
                BillItems = new List<BillItem>()
                {
                        new BillItem()
                        {
                            Description = "Repair swimming pool",
                            Amount = "40",
                            PricePerUnit = 105,
                            TotalPrice = 4200
                        }
                        , new BillItem()
                        {
                            Description = "Garden works",
                            Amount = "25",
                            PricePerUnit = 155,
                            TotalPrice = 3875
                        }, new BillItem()
                        {
                            Description = "Repair water heater",
                            Amount = "5",
                            PricePerUnit = 55,
                            TotalPrice = 275
                        }, new BillItem()
                        {
                            Description = "Repair & Replace Faucets",
                            Amount = "1",
                            PricePerUnit = 90,
                            TotalPrice = 90
                        }, new BillItem()
                        {
                            Description = "House cleaning",
                            Amount = "10",
                            PricePerUnit = 25,
                            TotalPrice = 250
                        }
                    }
            };
        }
    }
    public class BillInfo {
        public QRBillPaymentPartData QRBillData { get; set; }
        public PersonInfo Debtor { get; set; }
        public PersonInfo Creditor { get; set; }
        public List<BillItem> BillItems { get; set; }
        public DateTime BillDate { get; set; }
        public string BillNumber { get; set; }

    }
    public class BillItem {
        public string Description { get; set; }
        public string Amount { get; set; }
        public float PricePerUnit { get; set; }
        public float TotalPrice { get; set; }
    }
    public class QRBillPaymentPartData {
        public string Support { get; set; }
        public string QRCodeData { get; set; }
        public string Currency { get; set; }
        public float Amount { get; set; }
        public string Account { get; set; }
        public string Creditor { get; set; }
        public string UltimateCreditor { get; set; }
        public string ReferenceNumber { get; set; }
        public string AdditionalInformation { get; set; }
        public string Debtor { get; set; }
        public DateTime DueDate { get; set; }

    }
    public class PersonInfo {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }

}
