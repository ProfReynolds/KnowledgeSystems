//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace Knowledge.MLNET.Demonstrator.Characters
{
    public class ModelInput
    {
        [ColumnName("Label"), LoadColumn(0)]
        public string Label { get; set; }


        [ColumnName("x_box"), LoadColumn(1)]
        public float X_box { get; set; }


        [ColumnName("y_box"), LoadColumn(2)]
        public float Y_box { get; set; }


        [ColumnName("width"), LoadColumn(3)]
        public float Width { get; set; }


        [ColumnName("height"), LoadColumn(4)]
        public float Height { get; set; }


        [ColumnName("onpix"), LoadColumn(5)]
        public float Onpix { get; set; }


        [ColumnName("x_bar"), LoadColumn(6)]
        public float X_bar { get; set; }


        [ColumnName("y_bar"), LoadColumn(7)]
        public float Y_bar { get; set; }


        [ColumnName("x2bar"), LoadColumn(8)]
        public float X2bar { get; set; }


        [ColumnName("y2bar"), LoadColumn(9)]
        public float Y2bar { get; set; }


        [ColumnName("xybar"), LoadColumn(10)]
        public float Xybar { get; set; }


        [ColumnName("x2ybar"), LoadColumn(11)]
        public float X2ybar { get; set; }


        [ColumnName("xy2bar"), LoadColumn(12)]
        public float Xy2bar { get; set; }


        [ColumnName("x_ege"), LoadColumn(13)]
        public float X_ege { get; set; }


        [ColumnName("xegvy"), LoadColumn(14)]
        public float Xegvy { get; set; }


        [ColumnName("y_ege"), LoadColumn(15)]
        public float Y_ege { get; set; }


        [ColumnName("yegvx"), LoadColumn(16)]
        public float Yegvx { get; set; }


    }
}
