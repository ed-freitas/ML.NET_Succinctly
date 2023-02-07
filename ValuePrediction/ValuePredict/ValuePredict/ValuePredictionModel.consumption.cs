﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;

namespace ValuePredict
{
    public partial class ValuePredictionModel
    {
        /// <summary>
        /// model input class for ValuePredictionModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"CRIM")]
            public float CRIM { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"ZN")]
            public float ZN { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"INDUS")]
            public float INDUS { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"CHAS")]
            public float CHAS { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"NOX")]
            public float NOX { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"RM")]
            public float RM { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"AGE")]
            public float AGE { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"DIS")]
            public float DIS { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"RAD")]
            public float RAD { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"TAX")]
            public float TAX { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"PTRATIO")]
            public float PTRATIO { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"B")]
            public float B { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"LSAT")]
            public float LSAT { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"MEDV")]
            public float MEDV { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for ValuePredictionModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"CRIM")]
            public float CRIM { get; set; }

            [ColumnName(@"ZN")]
            public float ZN { get; set; }

            [ColumnName(@"INDUS")]
            public float INDUS { get; set; }

            [ColumnName(@"CHAS")]
            public float CHAS { get; set; }

            [ColumnName(@"NOX")]
            public float NOX { get; set; }

            [ColumnName(@"RM")]
            public float RM { get; set; }

            [ColumnName(@"AGE")]
            public float AGE { get; set; }

            [ColumnName(@"DIS")]
            public float DIS { get; set; }

            [ColumnName(@"RAD")]
            public float RAD { get; set; }

            [ColumnName(@"TAX")]
            public float TAX { get; set; }

            [ColumnName(@"PTRATIO")]
            public float PTRATIO { get; set; }

            [ColumnName(@"B")]
            public float B { get; set; }

            [ColumnName(@"LSAT")]
            public float LSAT { get; set; }

            [ColumnName(@"MEDV")]
            public float MEDV { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("ValuePredictionModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
