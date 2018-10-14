using System;
//using A_HelloWorld;

public class _Demo
{
    static void Main(string[] args)
    {
        A_HelloWorld.HelloWorld.demo();
        B_initialize_order.B.demo();
        C_Function_parms.NumberManipulator.demo();
        C_Function_parms.NumberManipulator2.demo();
        D_Nullable.NullablesAtShow.demo();
        E_ArrayApplication.MyArray.demo(34, 72, 13, 44, 25, 30, 10);
        F_EnumApplication.EnumProgram.demo();
        G_Destructor.Line.demo();
        H_OperatorOvlApplication.Tester.demo();
        I_Preprocessor.Class.demo();
        J_UserDefinedException.TestTemperature.demo();
        K_FileIOApplication.Test.demo();
        L_Attribute.Test.demo();
        M_property.Demo.demo();
        N_Indexer.IndexedNames.demo();
        O_Delegate.PrintString.demo();
        O_Delegate.FuncDemo.demo();
        P_Event.RecordBoilerInfo.demo();
        Q_Collection.ArrayListDemo.demo();
        Q_Collection.HashtableDemo.demo();
        Q_Collection.SortedListDemo.demo();
        Q_Collection.StackDemo.demo();
        Q_Collection.QueueDemo.demo();
        R_Anonymous_Func.TestDelegate.demo();
        //S_Threading.ThreadCreationDemo.demo();
        T_ExtendMethod.Demo.demo();

        Console.ReadLine();
    }
}
