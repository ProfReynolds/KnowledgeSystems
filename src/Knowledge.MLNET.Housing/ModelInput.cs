﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace Knowledge.MLNET.Housing
{
    class ModelInput
    {
        [ColumnName("Id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("MSSubClass"), LoadColumn(1)]
        public float MSSubClass { get; set; }


        [ColumnName("MSZoning"), LoadColumn(2)]
        public string MSZoning { get; set; }


        [ColumnName("LotFrontage"), LoadColumn(3)]
        public float LotFrontage { get; set; }


        [ColumnName("LotArea"), LoadColumn(4)]
        public float LotArea { get; set; }


        [ColumnName("Street"), LoadColumn(5)]
        public string Street { get; set; }


        [ColumnName("Alley"), LoadColumn(6)]
        public string Alley { get; set; }


        [ColumnName("LotShape"), LoadColumn(7)]
        public string LotShape { get; set; }


        [ColumnName("LandContour"), LoadColumn(8)]
        public string LandContour { get; set; }


        [ColumnName("Utilities"), LoadColumn(9)]
        public string Utilities { get; set; }


        [ColumnName("LotConfig"), LoadColumn(10)]
        public string LotConfig { get; set; }


        [ColumnName("LandSlope"), LoadColumn(11)]
        public string LandSlope { get; set; }


        [ColumnName("Neighborhood"), LoadColumn(12)]
        public string Neighborhood { get; set; }


        [ColumnName("Condition1"), LoadColumn(13)]
        public string Condition1 { get; set; }


        [ColumnName("Condition2"), LoadColumn(14)]
        public string Condition2 { get; set; }


        [ColumnName("BldgType"), LoadColumn(15)]
        public string BldgType { get; set; }


        [ColumnName("HouseStyle"), LoadColumn(16)]
        public string HouseStyle { get; set; }


        [ColumnName("OverallQual"), LoadColumn(17)]
        public float OverallQual { get; set; }


        [ColumnName("OverallCond"), LoadColumn(18)]
        public float OverallCond { get; set; }


        [ColumnName("YearBuilt"), LoadColumn(19)]
        public float YearBuilt { get; set; }


        [ColumnName("YearRemodAdd"), LoadColumn(20)]
        public float YearRemodAdd { get; set; }


        [ColumnName("RoofStyle"), LoadColumn(21)]
        public string RoofStyle { get; set; }


        [ColumnName("RoofMatl"), LoadColumn(22)]
        public string RoofMatl { get; set; }


        [ColumnName("Exterior1st"), LoadColumn(23)]
        public string Exterior1st { get; set; }


        [ColumnName("Exterior2nd"), LoadColumn(24)]
        public string Exterior2nd { get; set; }


        [ColumnName("MasVnrType"), LoadColumn(25)]
        public string MasVnrType { get; set; }


        [ColumnName("MasVnrArea"), LoadColumn(26)]
        public float MasVnrArea { get; set; }


        [ColumnName("ExterQual"), LoadColumn(27)]
        public string ExterQual { get; set; }


        [ColumnName("ExterCond"), LoadColumn(28)]
        public string ExterCond { get; set; }


        [ColumnName("Foundation"), LoadColumn(29)]
        public string Foundation { get; set; }


        [ColumnName("BsmtQual"), LoadColumn(30)]
        public string BsmtQual { get; set; }


        [ColumnName("BsmtCond"), LoadColumn(31)]
        public string BsmtCond { get; set; }


        [ColumnName("BsmtExposure"), LoadColumn(32)]
        public string BsmtExposure { get; set; }


        [ColumnName("BsmtFinType1"), LoadColumn(33)]
        public string BsmtFinType1 { get; set; }


        [ColumnName("BsmtFinSF1"), LoadColumn(34)]
        public float BsmtFinSF1 { get; set; }


        [ColumnName("BsmtFinType2"), LoadColumn(35)]
        public string BsmtFinType2 { get; set; }


        [ColumnName("BsmtFinSF2"), LoadColumn(36)]
        public float BsmtFinSF2 { get; set; }


        [ColumnName("BsmtUnfSF"), LoadColumn(37)]
        public float BsmtUnfSF { get; set; }


        [ColumnName("TotalBsmtSF"), LoadColumn(38)]
        public float TotalBsmtSF { get; set; }


        [ColumnName("Heating"), LoadColumn(39)]
        public string Heating { get; set; }


        [ColumnName("HeatingQC"), LoadColumn(40)]
        public string HeatingQC { get; set; }


        [ColumnName("CentralAir"), LoadColumn(41)]
        public bool CentralAir { get; set; }


        [ColumnName("Electrical"), LoadColumn(42)]
        public string Electrical { get; set; }


        [ColumnName("1stFlrSF"), LoadColumn(43)]
        public float Col1stFlrSF { get; set; }


        [ColumnName("2ndFlrSF"), LoadColumn(44)]
        public float Col2ndFlrSF { get; set; }


        [ColumnName("LowQualFinSF"), LoadColumn(45)]
        public float LowQualFinSF { get; set; }


        [ColumnName("GrLivArea"), LoadColumn(46)]
        public float GrLivArea { get; set; }


        [ColumnName("BsmtFullBath"), LoadColumn(47)]
        public float BsmtFullBath { get; set; }


        [ColumnName("BsmtHalfBath"), LoadColumn(48)]
        public float BsmtHalfBath { get; set; }


        [ColumnName("FullBath"), LoadColumn(49)]
        public float FullBath { get; set; }


        [ColumnName("HalfBath"), LoadColumn(50)]
        public float HalfBath { get; set; }


        [ColumnName("BedroomAbvGr"), LoadColumn(51)]
        public float BedroomAbvGr { get; set; }


        [ColumnName("KitchenAbvGr"), LoadColumn(52)]
        public float KitchenAbvGr { get; set; }


        [ColumnName("KitchenQual"), LoadColumn(53)]
        public string KitchenQual { get; set; }


        [ColumnName("TotRmsAbvGrd"), LoadColumn(54)]
        public float TotRmsAbvGrd { get; set; }


        [ColumnName("Functional"), LoadColumn(55)]
        public string Functional { get; set; }


        [ColumnName("Fireplaces"), LoadColumn(56)]
        public float Fireplaces { get; set; }


        [ColumnName("FireplaceQu"), LoadColumn(57)]
        public string FireplaceQu { get; set; }


        [ColumnName("GarageType"), LoadColumn(58)]
        public string GarageType { get; set; }


        [ColumnName("GarageYrBlt"), LoadColumn(59)]
        public float GarageYrBlt { get; set; }


        [ColumnName("GarageFinish"), LoadColumn(60)]
        public string GarageFinish { get; set; }


        [ColumnName("GarageCars"), LoadColumn(61)]
        public float GarageCars { get; set; }


        [ColumnName("GarageArea"), LoadColumn(62)]
        public float GarageArea { get; set; }


        [ColumnName("GarageQual"), LoadColumn(63)]
        public string GarageQual { get; set; }


        [ColumnName("GarageCond"), LoadColumn(64)]
        public string GarageCond { get; set; }


        [ColumnName("PavedDrive"), LoadColumn(65)]
        public string PavedDrive { get; set; }


        [ColumnName("WoodDeckSF"), LoadColumn(66)]
        public float WoodDeckSF { get; set; }


        [ColumnName("OpenPorchSF"), LoadColumn(67)]
        public float OpenPorchSF { get; set; }


        [ColumnName("EnclosedPorch"), LoadColumn(68)]
        public float EnclosedPorch { get; set; }


        [ColumnName("3SsnPorch"), LoadColumn(69)]
        public float Col3SsnPorch { get; set; }


        [ColumnName("ScreenPorch"), LoadColumn(70)]
        public float ScreenPorch { get; set; }


        [ColumnName("PoolArea"), LoadColumn(71)]
        public float PoolArea { get; set; }


        [ColumnName("PoolQC"), LoadColumn(72)]
        public string PoolQC { get; set; }


        [ColumnName("Fence"), LoadColumn(73)]
        public string Fence { get; set; }


        [ColumnName("MiscFeature"), LoadColumn(74)]
        public string MiscFeature { get; set; }


        [ColumnName("MiscVal"), LoadColumn(75)]
        public float MiscVal { get; set; }


        [ColumnName("MoSold"), LoadColumn(76)]
        public float MoSold { get; set; }


        [ColumnName("YrSold"), LoadColumn(77)]
        public float YrSold { get; set; }


        [ColumnName("SaleType"), LoadColumn(78)]
        public string SaleType { get; set; }


        [ColumnName("SaleCondition"), LoadColumn(79)]
        public string SaleCondition { get; set; }


        [ColumnName("SalePrice"), LoadColumn(80)]
        public float SalePrice { get; set; }


    }
}
