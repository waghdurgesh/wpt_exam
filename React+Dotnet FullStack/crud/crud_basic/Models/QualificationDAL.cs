using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;

namespace crud_basic.Models;
public class QualificationDAL{

transflower_misContext qual = new transflower_misContext();

public IEnumerable<Qualification> GetAllQualifiactions()
{
    try{
        return qual.Qualifications.ToList();
    }catch{
        throw;
    }
}

public int DeleteQualifications(int id){
    try{
        Qualification degree = qual.Qualifications.Find(id);
        qual.Qualifications.Remove(degree);
        qual.SaveChanges();
        return 1;
    }catch{
        throw;
    }
}










}