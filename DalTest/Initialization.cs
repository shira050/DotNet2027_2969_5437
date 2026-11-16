using DalApi;
using DO;
using System;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void createTests()
    {
        s_dal!.Test.Create(new Test(0, (Subject)1, DateTime.Now, 10));
        s_dal.Test.Create(new Test(0, (Subject)2, DateTime.Now.AddDays(1), 15));
        s_dal.Test.Create(new Test(0, (Subject)1, DateTime.Now.AddDays(2), 20));
        s_dal.Test.Create(new Test(0, (Subject)3, DateTime.Now.AddDays(3), 5));
        s_dal.Test.Create(new Test(0, (Subject)2, DateTime.Now.AddDays(4), 12));
    }

    public static void Initialize(IDal dal)
    {
        s_dal = dal; 
        createTests();
    }
}