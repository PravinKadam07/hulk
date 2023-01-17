namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class StManager{
    public static void InsertStud(Student stud){
    DbManager.InsertStudentData(stud);

    } 
}

// public static void InsertStudentData(Student std){
//         DBManager.InsertStudentData(std);
    