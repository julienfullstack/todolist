using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
   public class CategoryTests : IDisposable
  {

    public void Dispose()
    {
      Category.ClearAll();
    }
    
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

      [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);

    //Act
    string result = newCategory.Name;

    //Assert
    Assert.AreEqual(name, result);
  }

 

  }
}