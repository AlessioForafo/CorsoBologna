#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class CreaVariabiliDesignTime : BaseNetLogic
{
    [ExportMethod]
    public void MetodoCreazioneVariabili()
    {
        // Insert code to be executed by the method

        for (int i = 0; i < 10; i++)
        {
            var miaVar = InformationModel.MakeVariable("MiaVar" + i, OpcUa.DataTypes.Int16);
            miaVar.Value = i;
            Project.Current.Get("Model/MieVariabili").Add(miaVar);
        }
    }
}
