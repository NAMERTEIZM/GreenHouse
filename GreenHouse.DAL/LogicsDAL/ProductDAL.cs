using GreenHouse.Core;
using GreenHouse.VM.Category;
using GreenHouse.VM.Company;
using GreenHouse.VM.Picture;
using GreenHouse.VM.Product;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
using GreenHouse.VM.User;
using GreenHouse.VM;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;

namespace GreenHouse.DAL.LogicsDAL
{
    public class ProductDAL
    {
        public List<IngredientSelectVM> GetIngredientsByProduct(ProductWithIngreadientsVM p)
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
            Urun product = productDAL.SelectAllWithInclude(x => x.ID == p.ID, "UrunIceriks.Bilesen.Risk").SingleOrDefault();

            List<UrunIcerik> productIngredients = product.UrunIceriks.ToList();

            List<IngredientSelectVM> ingredientSelectVMs = new List<IngredientSelectVM>();

            productIngredients.ForEach(x =>
            {
                ingredientSelectVMs.Add(new IngredientSelectVM
                {
                    ID = x.BilesenID,
                    Adi = x.Bilesen.Adi,
                    RiskTur = x.Bilesen.Risk.RiskTur
                });
            });

            return ingredientSelectVMs;
        }

        public List<ProductSelectVM> GetProducts()
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());

            List<Urun> products = productDAL.SelectAllWithAsNoTracking();

            List<ProductSelectVM> productvms = new List<ProductSelectVM>();

            products.ForEach(x =>
            {
                List<PictureSelectVM> pictureList = new List<PictureSelectVM>();
                foreach (var item in x.Resims)
                {
                    PictureSelectVM picture = new PictureSelectVM
                    {
                        ID = item.ID,
                        ResimYolu = item.ResimYolu,
                        ResimYuzu = item.ResimYuzu,
                        UrunID = item.UrunID
                    };
                    pictureList.Add(picture);
                }

                bool hideState = false;
                string nameAndSurname = "";
                foreach (var item in x.UrunOnays)
                {
                    hideState = item.OnayDurumu.Value;
                    nameAndSurname = item.KullaniciRolu.Kullanici.Adi + " " + item.KullaniciRolu.Kullanici.Soyadi;
                }

                List<ProductCompanySelectVM> productCompanyList = new List<ProductCompanySelectVM>();
                foreach (var item in x.UrunFirmas)
                {
                    CompanySelectVM company = new CompanySelectVM
                    {
                        FirmaAdi = item.Firma.FirmaAdi,
                        FirmaAdresi = item.Firma.FirmaAdresi,
                        FirmaTel = item.Firma.FirmaTel,
                        ID = item.Firma.ID,
                        AktifMi = item.Firma.AktifMi
                    };

                    ProductCompanySelectVM productcompany = new ProductCompanySelectVM
                    {
                        UrunID = item.UrunID,
                        FirmaID = item.FirmaID,
                        Firma = company
                    };
                    productCompanyList.Add(productcompany);
                }

                List<ProductIngredientSelectVM> productIngredientList = new List<ProductIngredientSelectVM>();
                foreach (var item in x.UrunIceriks)
                {
                    IngredientSelectVM ingredient = new IngredientSelectVM
                    {
                        Adi = item.Bilesen.Adi,
                        ID = item.Bilesen.ID,
                        RiskTur = item.Bilesen.Risk.RiskTur
                    };

                    ProductIngredientSelectVM productingredient = new ProductIngredientSelectVM
                    {
                        Bilesen = ingredient,
                        BilesenID = item.Bilesen.ID,
                        UrunID = item.Urun.ID
                    };

                    productIngredientList.Add(productingredient);
                }

                CategorySelectVM categorySelectVM = new CategorySelectVM { ID = x.KategoriID, KategoriAdi = x.UrunKategori.KategoriAdi, UstKategori = x.UrunKategori.UrunKategori2, UstKategoriID = x.UrunKategori.UstKategoriID };


                productvms.Add(new ProductSelectVM
                {
                    ID = x.ID,
                    UrunAdi = x.UrunAdi,
                    AktifMi = x.AktifMi,
                    BarkodNumarasi = x.BarkodNumarasi,
                    KategoriID = x.KategoriID,
                    Resims = pictureList,
                    UrunAciklamasi = x.UrunAciklamasi,
                    UrunFirmas = productCompanyList,
                    UrunIceriks = productIngredientList,
                    Kategori = categorySelectVM,
                    HideState = hideState,
                    NameAndSurname = nameAndSurname
                });
            });

            return productvms;
        }

        public ProductInsertVM UpdateProduct(ProductInsertVM productUpdateVM)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
                    EFRepo<Resim> pictureDAL = new EFRepo<Resim>(new GreenHouseContext());
                    EFRepo<UrunIcerik> productIngredientDAL = new EFRepo<UrunIcerik>(new GreenHouseContext());
                    EFRepo<UrunFirma> producerDAL = new EFRepo<UrunFirma>(new GreenHouseContext());

                    // Mevcut ürünü veritabanından al
                    Urun existingProduct = productDAL.SelectAll(x => x.ID == productUpdateVM.ID).SingleOrDefault();

                    if (existingProduct != null)
                    {
                        // Ürün verilerini güncelle
                        existingProduct.UrunAdi = productUpdateVM.UrunAdi;
                        existingProduct.KategoriID = productUpdateVM.UrunKategori.ID;
                        existingProduct.UrunAciklamasi = productUpdateVM.UrunAciklamasi;
                        existingProduct.BarkodNumarasi = productUpdateVM.BarkodNumarasi;

                        productDAL.Update(existingProduct);

                        productUpdateVM.Resims.ForEach(x =>
                        {
                            Resim picture = new Resim
                            {
                                ID = x.ID,
                                ResimYolu = x.ResimYolu,
                                ResimYuzu = x.ResimYuzu,
                                UrunID = x.UrunID
                            };
                            pictureDAL.HardDelete(picture);
                        });


                        // Yeni resimleri ekle
                        foreach (var newPicture in productUpdateVM.Resims)
                        {
                            newPicture.ID = Guid.NewGuid();
                            newPicture.UrunID = existingProduct.ID;
                            MyEntityMapper<PictureSelectVM, Resim> mapper = new MyEntityMapper<PictureSelectVM, Resim>();
                            Resim resim = mapper.Map<PictureSelectVM, Resim>(newPicture);
                            pictureDAL.Add(resim);
                        }

                        existingProduct.UrunIceriks.ToList().ForEach(x =>
                        {
                            UrunIcerik productingredient = new UrunIcerik
                            {
                                BilesenID = x.BilesenID,
                                UrunID = productUpdateVM.ID
                            };
                            productIngredientDAL.HardDelete(productingredient);
                        });

                        foreach (var newIngredient in productUpdateVM.UrunIceriks)
                        {
                            UrunIcerik ui = new UrunIcerik { BilesenID = newIngredient.BilesenID, UrunID = existingProduct.ID };
                            productIngredientDAL.Add(ui);
                        }

                        existingProduct.UrunFirmas.ToList().ForEach(x =>
                        {
                            UrunFirma productcompany = new UrunFirma
                            {
                                UrunID = x.UrunID,
                                FirmaID = x.FirmaID
                            };
                            producerDAL.HardDelete(productcompany);
                        });

                        foreach (var newProducer in productUpdateVM.UrunFirmas)
                        {
                            UrunFirma uf = new UrunFirma { FirmaID = newProducer.FirmaID, UrunID = existingProduct.ID };
                            producerDAL.Add(uf);
                        }

                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw;
                }
            }

            return productUpdateVM;
        }

        public ProductInsertVM DeleteProduct(ProductInsertVM productUpdateVM)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
                    EFRepo<Resim> pictureDAL = new EFRepo<Resim>(new GreenHouseContext());
                    EFRepo<UrunIcerik> productIngredientDAL = new EFRepo<UrunIcerik>(new GreenHouseContext());
                    EFRepo<UrunFirma> producerDAL = new EFRepo<UrunFirma>(new GreenHouseContext());
                    EFRepo<UrunOnay> approvDAL = new EFRepo<UrunOnay>(new GreenHouseContext());

                    // Mevcut ürünü veritabanından al
                    Urun existingProduct = productDAL.SelectAll(x => x.ID == productUpdateVM.ID).SingleOrDefault();

                    if (existingProduct != null)
                    {

                        existingProduct.Resims.ToList().ForEach(x =>
                        {
                            Resim picture = new Resim
                            {
                                ID = x.ID,
                                ResimYolu = x.ResimYolu,
                                ResimYuzu = x.ResimYuzu,
                                UrunID = x.UrunID
                            };
                            pictureDAL.HardDelete(picture);
                        });

                        existingProduct.UrunIceriks.ToList().ForEach(x =>
                        {
                            UrunIcerik productingredient = new UrunIcerik
                            {
                                BilesenID = x.BilesenID,
                                UrunID = productUpdateVM.ID
                            };
                            productIngredientDAL.HardDelete(productingredient);
                        });

                        existingProduct.UrunFirmas.ToList().ForEach(x =>
                        {
                            UrunFirma productcompany = new UrunFirma
                            {
                                UrunID = x.UrunID,
                                FirmaID = x.FirmaID
                            };
                            producerDAL.HardDelete(productcompany);
                        });

                        existingProduct.UrunOnays.ToList().ForEach(x =>
                        {
                            UrunOnay productApprov = new UrunOnay
                            {
                                ID = x.ID,
                                UrunID = productUpdateVM.ID
                            };
                            approvDAL.HardDelete(productApprov);
                        });

                        productDAL.SoftDelete(existingProduct);

                        scope.Complete();
                    }
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw;
                }
            }

            return productUpdateVM;
        }

        public ProductInsertVM AddProducts(ProductInsertVM productInsertVM)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
                    EFRepo<Resim> pictureDAL = new EFRepo<Resim>(new GreenHouseContext());
                    EFRepo<UrunIcerik> productIngredientDAL = new EFRepo<UrunIcerik>(new GreenHouseContext());
                    EFRepo<UrunFirma> producerDAL = new EFRepo<UrunFirma>(new GreenHouseContext());
                    EFRepo<UrunOnay> productApprovDAL = new EFRepo<UrunOnay>(new GreenHouseContext());

                    Guid guid = Guid.NewGuid();

                    Urun product = new Urun
                    {
                        ID = guid,
                        UrunAdi = productInsertVM.UrunAdi,
                        KategoriID = productInsertVM.UrunKategori.ID,
                        UrunAciklamasi = productInsertVM.UrunAciklamasi,
                        BarkodNumarasi = productInsertVM.BarkodNumarasi,
                        OlusturulmaTarihi = DateTime.Now,
                    };

                    productDAL.Add(product);

                    productInsertVM.Resims.ForEach(x =>
                    {
                        x.ID = Guid.NewGuid();
                        x.UrunID = product.ID;
                        MyEntityMapper<PictureSelectVM, Resim> mapper = new MyEntityMapper<PictureSelectVM, Resim>();
                        Resim resim = mapper.Map<PictureSelectVM, Resim>(x);
                        pictureDAL.Add(resim);
                    });

                    productInsertVM.UrunFirmas.ForEach(x =>
                    {
                        UrunFirma uf = new UrunFirma { FirmaID = x.FirmaID, UrunID = guid };
                        producerDAL.Add(uf);
                    });

                    productInsertVM.UrunIceriks.ForEach(x =>
                    {
                        UrunIcerik ui = new UrunIcerik { BilesenID = x.BilesenID, UrunID = guid };
                        productIngredientDAL.Add(ui);
                    });

                    Random random = new Random();

                    UrunOnay productApprov = new UrunOnay
                    {
                        ID = Guid.NewGuid(),
                        OnayDurumu = true,
                        TakipNumarasi = random.Next(1, 999999).ToString(),
                        UrunID = guid,
                        KullaniciGozukmeDurumu = false,
                        EkleyenKullaniciRolID = Guid.Parse("bf48c065-487b-48ba-bec6-757a14361e2b"),
                        InceleyenKullaniciRolID = Guid.Parse("bf48c065-487b-48ba-bec6-757a14361e2b")
                    };

                    productApprovDAL.Add(productApprov);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw;
                }
            }

            return productInsertVM;
        }


        public ProductUserInsertVM AddProductsUser(ProductUserInsertVM productUserInsertVM, UserDetailVM userDetailVM)
        {
            using (var scope = new TransactionScope())
            {
                try
                {

                    EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
                    EFRepo<Resim> pictureDAL = new EFRepo<Resim>(new GreenHouseContext());
                    EFRepo<UrunIcerik> productIngredientDAL = new EFRepo<UrunIcerik>(new GreenHouseContext());
                    EFRepo<UrunFirma> producerDAL = new EFRepo<UrunFirma>(new GreenHouseContext());
                    EFRepo<UrunOnay> productApprovDAL = new EFRepo<UrunOnay>(new GreenHouseContext());

                    Guid guid = Guid.NewGuid();

                    Urun product = new Urun
                    {
                        ID = guid,
                        UrunAdi = productUserInsertVM.UrunAdi,
                        KategoriID = productUserInsertVM.UrunKategori.ID,
                        UrunAciklamasi = productUserInsertVM.UrunAciklamasi,
                        BarkodNumarasi = productUserInsertVM.BarkodNumarasi,
                        OlusturulmaTarihi = DateTime.Now,
                    };

                    productDAL.Add(product);

                    productUserInsertVM.Resims.ForEach(x =>
                    {
                        x.ID = Guid.NewGuid();
                        x.UrunID = product.ID;
                        MyEntityMapper<PictureSelectVM, Resim> mapper = new MyEntityMapper<PictureSelectVM, Resim>();
                        Resim resim = mapper.Map<PictureSelectVM, Resim>(x);
                        pictureDAL.Add(resim);
                    });

                    productUserInsertVM.UrunFirmas.ForEach(x =>
                    {
                        UrunFirma uf = new UrunFirma { FirmaID = x.FirmaID, UrunID = guid };
                        producerDAL.Add(uf);
                    });

                    productUserInsertVM.UrunIceriks.ForEach(x =>
                    {
                        UrunIcerik ui = new UrunIcerik { BilesenID = x.BilesenID, UrunID = guid };
                        productIngredientDAL.Add(ui);
                    });

                    Random random = new Random();

                    UrunOnay productApprov = new UrunOnay
                    {
                        ID = Guid.NewGuid(),
                        OnayDurumu = false,
                        TakipNumarasi = random.Next(1, 999999).ToString(),
                        UrunID = guid,
                        KullaniciGozukmeDurumu = productUserInsertVM.KullaniciGozukmeDurumu,
                        EkleyenKullaniciRolID = userDetailVM.UserRoleID
                        //InceleyenKullaniciRolID = Guid.Parse("bf48c065-487b-48ba-bec6-757a14361e2b")
                    };

                    productApprovDAL.Add(productApprov);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                    throw;
                }
            }

            return productUserInsertVM;
        }

        public List<ProductSelectVM> GetProductsFilter(string nameOrBarcode, int categoryId)
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());

            List<Urun> products = productDAL.SelectAllWithAsNoTracking(x =>
            (x.UrunAdi.Contains(nameOrBarcode) || x.BarkodNumarasi.Contains(nameOrBarcode)) &&
            (categoryId == 0 || x.KategoriID == categoryId) &&
            x.UrunOnays.Any(onay => onay.OnayDurumu == true));

            List<ProductSelectVM> productvms = new List<ProductSelectVM>();

            products.ForEach(x =>
            {                
                List<PictureSelectVM> pictureList = new List<PictureSelectVM>();
                foreach (var item in x.Resims)
                {
                    PictureSelectVM picture = new PictureSelectVM
                    {
                        ID = item.ID,
                        ResimYolu = item.ResimYolu,
                        ResimYuzu = item.ResimYuzu,
                        UrunID = item.UrunID
                    };
                    pictureList.Add(picture);
                }

                bool hideState = false;
                string nameAndSurname = "";
                foreach (var item in x.UrunOnays)
                {
                    hideState = item.KullaniciGozukmeDurumu.Value;
                    nameAndSurname = item.KullaniciRolu.Kullanici.Adi + " " + item.KullaniciRolu.Kullanici.Soyadi;
                }

                List<ProductCompanySelectVM> productCompanyList = new List<ProductCompanySelectVM>();
                foreach (var item in x.UrunFirmas)
                {
                    CompanySelectVM company = new CompanySelectVM
                    {
                        FirmaAdi = item.Firma.FirmaAdi,
                        FirmaAdresi = item.Firma.FirmaAdresi,
                        FirmaTel = item.Firma.FirmaTel,
                        ID = item.Firma.ID,
                        AktifMi = item.Firma.AktifMi
                    };

                    ProductCompanySelectVM productcompany = new ProductCompanySelectVM
                    {
                        UrunID = item.UrunID,
                        FirmaID = item.FirmaID,
                        Firma = company
                    };
                    productCompanyList.Add(productcompany);
                }

                List<ProductIngredientSelectVM> productIngredientList = new List<ProductIngredientSelectVM>();
                foreach (var item in x.UrunIceriks)
                {
                    IngredientSelectVM ingredient = new IngredientSelectVM
                    {
                        Adi = item.Bilesen.Adi,
                        ID = item.Bilesen.ID,
                        RiskTur = item.Bilesen.Risk.RiskTur
                    };

                    ProductIngredientSelectVM productingredient = new ProductIngredientSelectVM
                    {
                        Bilesen = ingredient,
                        BilesenID = item.Bilesen.ID,
                        UrunID = item.Urun.ID
                    };

                    productIngredientList.Add(productingredient);
                }

                CategorySelectVM categorySelectVM = new CategorySelectVM
                {
                    ID = x.KategoriID,
                    KategoriAdi = x.UrunKategori.KategoriAdi,
                    UstKategori = x.UrunKategori.UrunKategori2,
                    UstKategoriID = x.UrunKategori.UstKategoriID
                };

                productvms.Add(new ProductSelectVM
                {
                    ID = x.ID,
                    UrunAdi = x.UrunAdi,
                    AktifMi = x.AktifMi,
                    BarkodNumarasi = x.BarkodNumarasi,
                    KategoriID = x.KategoriID,
                    Resims = pictureList,
                    UrunAciklamasi = x.UrunAciklamasi,
                    UrunFirmas = productCompanyList,
                    UrunIceriks = productIngredientList,
                    Kategori = categorySelectVM,
                    HideState = hideState,
                    NameAndSurname = nameAndSurname

                });
            });

            return productvms;
        }


        public Urun GetProductByID(Guid productID)
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());
            Urun product = productDAL.SelectAll(x => x.ID == productID).SingleOrDefault();

            return product;
        }

        public List<ProductApproveSelectVM> GetProductsApprove()
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());

            List<Urun> products = productDAL.SelectAllWithInclude("UrunOnays.KullaniciRolu.Kullanici").OrderByDescending(p => p.OlusturulmaTarihi).ToList();

            List<ProductApproveSelectVM> productvms = new List<ProductApproveSelectVM>();

            products.ForEach(x =>
            {
                string firstName = "", lastName = "";
                Guid userID = Guid.Empty;
                Guid userRoleID = Guid.Empty;
                bool? approveStatus = false;
                foreach (var item in x.UrunOnays)
                {
                    firstName = item.KullaniciRolu.Kullanici.Adi;
                    lastName = item.KullaniciRolu.Kullanici.Soyadi;
                    userID = item.KullaniciRolu.Kullanici.ID;
                    userRoleID = item.KullaniciRolu.ID;
                    approveStatus = item.OnayDurumu;
                };

                productvms.Add(new ProductApproveSelectVM
                {
                    ProductID = x.ID,
                    Adi = firstName,
                    Soyadi = lastName,
                    KullaniciID = userID,
                    KullaniciRolID = userRoleID,
                    OlusturulmaTarihi = x.OlusturulmaTarihi,
                    OnayDurumu = approveStatus,
                    BarkodNumarasi = x.BarkodNumarasi,
                    UrunAdi = x.UrunAdi
                });

            });

            return productvms;
        }

        public ProductSelectVM GetProductDetail(Guid productID)
        {
            EFRepo<Urun> productDAL = new EFRepo<Urun>(new GreenHouseContext());

            Urun x = productDAL.SelectAllWithAsNoTracking(p=> p.ID == productID).SingleOrDefault();

            List<ProductSelectVM> productvms = new List<ProductSelectVM>();


            List<PictureSelectVM> pictureList = new List<PictureSelectVM>();
            foreach (var item in x.Resims)
            {
                PictureSelectVM picture = new PictureSelectVM
                {
                    ID = item.ID,
                    ResimYolu = item.ResimYolu,
                    ResimYuzu = item.ResimYuzu,
                    UrunID = item.UrunID
                };
                pictureList.Add(picture);
            }

            bool hideState = false;
            string nameAndSurname = "";
            foreach (var item in x.UrunOnays)
            {
                hideState = item.OnayDurumu.Value;
                nameAndSurname = item.KullaniciRolu.Kullanici.Adi + " " + item.KullaniciRolu.Kullanici.Soyadi;
            }

            List<ProductCompanySelectVM> productCompanyList = new List<ProductCompanySelectVM>();
            foreach (var item in x.UrunFirmas)
            {
                CompanySelectVM company = new CompanySelectVM
                {
                    FirmaAdi = item.Firma.FirmaAdi,
                    FirmaAdresi = item.Firma.FirmaAdresi,
                    FirmaTel = item.Firma.FirmaTel,
                    ID = item.Firma.ID,
                    AktifMi = item.Firma.AktifMi
                };

                ProductCompanySelectVM productcompany = new ProductCompanySelectVM
                {
                    UrunID = item.UrunID,
                    FirmaID = item.FirmaID,
                    Firma = company
                };
                productCompanyList.Add(productcompany);
            }

            List<ProductIngredientSelectVM> productIngredientList = new List<ProductIngredientSelectVM>();
            foreach (var item in x.UrunIceriks)
            {
                IngredientSelectVM ingredient = new IngredientSelectVM
                {
                    Adi = item.Bilesen.Adi,
                    ID = item.Bilesen.ID,
                    RiskTur = item.Bilesen.Risk.RiskTur
                };

                ProductIngredientSelectVM productingredient = new ProductIngredientSelectVM
                {
                    Bilesen = ingredient,
                    BilesenID = item.Bilesen.ID,
                    UrunID = item.Urun.ID
                };

                productIngredientList.Add(productingredient);
            }

            CategorySelectVM categorySelectVM = new CategorySelectVM { ID = x.KategoriID, KategoriAdi = x.UrunKategori.KategoriAdi, UstKategori = x.UrunKategori.UrunKategori2, UstKategoriID = x.UrunKategori.UstKategoriID };
         
            return new ProductSelectVM
            {
                ID = x.ID,
                UrunAdi = x.UrunAdi,
                AktifMi = x.AktifMi,
                BarkodNumarasi = x.BarkodNumarasi,
                KategoriID = x.KategoriID,
                Resims = pictureList,
                UrunAciklamasi = x.UrunAciklamasi,
                UrunFirmas = productCompanyList,
                UrunIceriks = productIngredientList,
                Kategori = categorySelectVM,
                HideState = hideState,
                NameAndSurname = nameAndSurname
            };
        }


        public bool UpdateProductApproveStatus(Guid productID)
        {
            EFRepo<UrunOnay> productApproveDAL = new EFRepo<UrunOnay>(new GreenHouseContext());

            UrunOnay existingProduct = productApproveDAL.SelectAll(x => x.UrunID == productID).SingleOrDefault();

            if (existingProduct != null)
            {
                existingProduct.OnayDurumu = true;

                productApproveDAL.Update(existingProduct);

                return true;
            }
            return false;
        }

        public List<ProductUserAddedVM> GetProductsByUserAdded(Guid userRolID)
        {
            EFRepo<UrunOnay> productDAL = new EFRepo<UrunOnay>(new GreenHouseContext());
            List<UrunOnay> products = productDAL.SelectAllWithAsNoTracking(x => x.EkleyenKullaniciRolID == userRolID);

            List<ProductUserAddedVM> productvms = new List<ProductUserAddedVM>();

            products.ForEach(x =>
            {
                productvms.Add(new ProductUserAddedVM

                {
                    ID = x.ID,
                    UrunAdi = x.Urun.UrunAdi,
                    BarkodNumarasi = x.Urun.BarkodNumarasi,
                    TakipNumarasi = x.TakipNumarasi,
                    OnayDurumu = x.OnayDurumu,

                });

            });

            return productvms;
        }

        public bool IsFavorite(Guid ProductId, Guid userRoleID, Guid ListID)
        {  
            EFRepo<ListeIcerigi> productDAL = new EFRepo<ListeIcerigi>(new GreenHouseContext());
            List<ListeIcerigi> item = productDAL.SelectAllWithInclude(x => x.KullaniciListesi.KullaniciRolID == userRoleID && x.KullaniciListesi.ID == ListID && x.IcerikID == ProductId && x.KullaniciListesi.ListeTip.ID != 2, "KullaniciListesi.ListeTip");

            if (item.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
