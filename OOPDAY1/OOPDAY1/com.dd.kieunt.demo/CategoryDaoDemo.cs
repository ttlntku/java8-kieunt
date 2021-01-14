﻿using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class CategoryDaoDemo
    {
        CategoryDAO categorydao = new CategoryDAO();
        public void insertTest(BaseRow row)
        {
            categorydao.Insert(row);
        }

        public void updateTest(BaseRow row)
        {
            categorydao.Update(row);
        }

        public void deleteTest(BaseRow row)
        {
            categorydao.Delete(row);
        }
        public void findAllTest()
        {
            categorydao.findAll();
        }
        public void findByIdTest(int id)
        {
            categorydao.findById(id);
        }
    }
}
