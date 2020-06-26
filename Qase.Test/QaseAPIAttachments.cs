using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Refit;
using System;
using System.IO;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPIAttachments
  {
    [TestMethod]
    public void GetAllAttachments()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filter = new BaseFilter();

        var attachments = qaseAPI.GetAllAttachmentsAsync("TEST", filter).Result;
      }
      catch (WebApiException ex)
      {
      }
      catch (ApiException ex)
      {
      }
      catch (Exception ex)
      {
      }
    }

    [TestMethod]
    public void GetSpecificAttachment()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var attachment = qaseAPI.GetSpecificAttachmentAsync("5b9d96e5a4dc75e71fe2378d65f9e9ea176ce479").Result;
    }

    [TestMethod]
    public void UploadAttachment()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var path = @"TestFiles\Test.pdf";

      using var stream = new FileStream(path, FileMode.Open);
      var attachment = qaseAPI.UploadAttachmentAsync("TEST", new StreamPart(stream, "test-streampart.pdf", "application/pdf")).Result;

    }

    [TestMethod]
    public void DeleteAttachment()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteAttachmentAsync("5b9d96e5a4dc75e71fe2378d65f9e9ea176ce479").Result;
    }
  }
}
