using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomDYO.Api.DataAccess
{
    public partial class OrderGraphicsTestContext : DbContext
    {
        public OrderGraphicsTestContext()
        {
        }

        public OrderGraphicsTestContext(DbContextOptions<OrderGraphicsTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrandLogoSize> BrandLogoSize { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<ColorCatagory> ColorCatagory { get; set; }
        public virtual DbSet<CommunicationLog> CommunicationLog { get; set; }
        public virtual DbSet<ConsumerFabric> ConsumerFabric { get; set; }
        public virtual DbSet<ConsumerFabricColor> ConsumerFabricColor { get; set; }
        public virtual DbSet<ConsumerProduct> ConsumerProduct { get; set; }
        public virtual DbSet<ConsumerProductCollarType> ConsumerProductCollarType { get; set; }
        public virtual DbSet<ConsumerProductCollarTypeDetail> ConsumerProductCollarTypeDetail { get; set; }
        public virtual DbSet<ConsumerProductCollarTypeDetailFabric> ConsumerProductCollarTypeDetailFabric { get; set; }
        public virtual DbSet<ConsumerProductColor> ConsumerProductColor { get; set; }
        public virtual DbSet<ConsumerProductCuff> ConsumerProductCuff { get; set; }
        public virtual DbSet<ConsumerProductFabric> ConsumerProductFabric { get; set; }
        public virtual DbSet<ConsumerProductFont> ConsumerProductFont { get; set; }
        public virtual DbSet<ConsumerProductLogo> ConsumerProductLogo { get; set; }
        public virtual DbSet<ConsumerProductPattern> ConsumerProductPattern { get; set; }
        public virtual DbSet<ConsumerProductPatternSection> ConsumerProductPatternSection { get; set; }
        public virtual DbSet<ConsumerProductPatternSectionFabric> ConsumerProductPatternSectionFabric { get; set; }
        public virtual DbSet<ConsumerProductPrintingMethod> ConsumerProductPrintingMethod { get; set; }
        public virtual DbSet<ConsumerProductSection> ConsumerProductSection { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryPort> CountryPort { get; set; }
        public virtual DbSet<CountryPortBackup> CountryPortBackup { get; set; }
        public virtual DbSet<CountryPortNewBackup> CountryPortNewBackup { get; set; }
        public virtual DbSet<CreditTermLimit> CreditTermLimit { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProduct { get; set; }
        public virtual DbSet<CustomerUser> CustomerUser { get; set; }
        public virtual DbSet<DecorationMethod> DecorationMethod { get; set; }
        public virtual DbSet<DelivieryMethod> DelivieryMethod { get; set; }
        public virtual DbSet<DesignCollarType> DesignCollarType { get; set; }
        public virtual DbSet<DesignCollarTypeDetail> DesignCollarTypeDetail { get; set; }
        public virtual DbSet<DesignCollarTypeDetailFabric> DesignCollarTypeDetailFabric { get; set; }
        public virtual DbSet<DesignCollarTypeDetailFabricColor> DesignCollarTypeDetailFabricColor { get; set; }
        public virtual DbSet<DesignCuff> DesignCuff { get; set; }
        public virtual DbSet<DesignCuffSection> DesignCuffSection { get; set; }
        public virtual DbSet<DesignCuffSectionFabric> DesignCuffSectionFabric { get; set; }
        public virtual DbSet<DesignCuffSectionFabricColor> DesignCuffSectionFabricColor { get; set; }
        public virtual DbSet<DesignPattern> DesignPattern { get; set; }
        public virtual DbSet<DesignPatternBrandLogo> DesignPatternBrandLogo { get; set; }
        public virtual DbSet<DesignPatternBrandLogoPrintingMethod> DesignPatternBrandLogoPrintingMethod { get; set; }
        public virtual DbSet<DesignPatternBrandLogoPrintingMethodColor> DesignPatternBrandLogoPrintingMethodColor { get; set; }
        public virtual DbSet<DesignPatternFont> DesignPatternFont { get; set; }
        public virtual DbSet<DesignPatternFontAlignment> DesignPatternFontAlignment { get; set; }
        public virtual DbSet<DesignPatternFontPrintingMethod> DesignPatternFontPrintingMethod { get; set; }
        public virtual DbSet<DesignPatternFontPrintingMethodColor> DesignPatternFontPrintingMethodColor { get; set; }
        public virtual DbSet<DesignPatternFontPrintingMethodFont> DesignPatternFontPrintingMethodFont { get; set; }
        public virtual DbSet<DesignPatternLogo> DesignPatternLogo { get; set; }
        public virtual DbSet<DesignPatternLogoPrintingMethod> DesignPatternLogoPrintingMethod { get; set; }
        public virtual DbSet<DesignPatternLogoPrintingMethodColor> DesignPatternLogoPrintingMethodColor { get; set; }
        public virtual DbSet<DesignPatternLogoTextUnderLogo> DesignPatternLogoTextUnderLogo { get; set; }
        public virtual DbSet<DesignPatternLogoTextUnderLogoPrintingMethod> DesignPatternLogoTextUnderLogoPrintingMethod { get; set; }
        public virtual DbSet<DesignPatternLogoTextUnderLogoPrintingMethodColor> DesignPatternLogoTextUnderLogoPrintingMethodColor { get; set; }
        public virtual DbSet<DesignPatternLogoTextUnderLogoPrintingMethodFont> DesignPatternLogoTextUnderLogoPrintingMethodFont { get; set; }
        public virtual DbSet<DesignPatternSection> DesignPatternSection { get; set; }
        public virtual DbSet<DesignPatternSectionFabric> DesignPatternSectionFabric { get; set; }
        public virtual DbSet<DesignPatternSectionFabricColor> DesignPatternSectionFabricColor { get; set; }
        public virtual DbSet<DesignQuote> DesignQuote { get; set; }
        public virtual DbSet<ElmahError> ElmahError { get; set; }
        public virtual DbSet<Fabric> Fabric { get; set; }
        public virtual DbSet<Font> Font { get; set; }
        public virtual DbSet<LineMaster> LineMaster { get; set; }
        public virtual DbSet<Logo> Logo { get; set; }
        public virtual DbSet<LogoApproval> LogoApproval { get; set; }
        public virtual DbSet<LogoCommunicationLog> LogoCommunicationLog { get; set; }
        public virtual DbSet<LogoCustomColors> LogoCustomColors { get; set; }
        public virtual DbSet<LogoLibraryApprovalUser> LogoLibraryApprovalUser { get; set; }
        public virtual DbSet<LogoLibraryNotifyUser> LogoLibraryNotifyUser { get; set; }
        public virtual DbSet<LogoLibraryStrikeOffLogos> LogoLibraryStrikeOffLogos { get; set; }
        public virtual DbSet<LogoStrikeOff> LogoStrikeOff { get; set; }
        public virtual DbSet<LogoStrikeOffLogo> LogoStrikeOffLogo { get; set; }
        public virtual DbSet<MailBox> MailBox { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<ModuleScreen> ModuleScreen { get; set; }
        public virtual DbSet<ModuleScreenDetail> ModuleScreenDetail { get; set; }
        public virtual DbSet<NumberofApproval> NumberofApproval { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderAddress> OrderAddress { get; set; }
        public virtual DbSet<OrderAddressN> OrderAddressN { get; set; }
        public virtual DbSet<OrderApprovalUser> OrderApprovalUser { get; set; }
        public virtual DbSet<OrderBackup> OrderBackup { get; set; }
        public virtual DbSet<OrderCarton> OrderCarton { get; set; }
        public virtual DbSet<OrderCartonDetail> OrderCartonDetail { get; set; }
        public virtual DbSet<OrderDesign> OrderDesign { get; set; }
        public virtual DbSet<OrderDesignDetail> OrderDesignDetail { get; set; }
        public virtual DbSet<OrderDesignN> OrderDesignN { get; set; }
        public virtual DbSet<OrderDesignStyle> OrderDesignStyle { get; set; }
        public virtual DbSet<OrderEmblishment> OrderEmblishment { get; set; }
        public virtual DbSet<OrderEmblishmentDetail> OrderEmblishmentDetail { get; set; }
        public virtual DbSet<OrderFactoryUser> OrderFactoryUser { get; set; }
        public virtual DbSet<OrderN> OrderN { get; set; }
        public virtual DbSet<OrderPickupDetail> OrderPickupDetail { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderStrikeOffLogos> OrderStrikeOffLogos { get; set; }
        public virtual DbSet<OrderWareHouseUser> OrderWareHouseUser { get; set; }
        public virtual DbSet<PatternSectionColor> PatternSectionColor { get; set; }
        public virtual DbSet<PrintingMethod> PrintingMethod { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductBrandLogo> ProductBrandLogo { get; set; }
        public virtual DbSet<ProductBrandLogoPrintingMethod> ProductBrandLogoPrintingMethod { get; set; }
        public virtual DbSet<ProductBrandLogoPrintingMethodColorCategory> ProductBrandLogoPrintingMethodColorCategory { get; set; }
        public virtual DbSet<ProductBrandLogoPrintingMethodColorCategoryColor> ProductBrandLogoPrintingMethodColorCategoryColor { get; set; }
        public virtual DbSet<ProductCatagory> ProductCatagory { get; set; }
        public virtual DbSet<ProductCollarType> ProductCollarType { get; set; }
        public virtual DbSet<ProductCollorTypeColorCategory> ProductCollorTypeColorCategory { get; set; }
        public virtual DbSet<ProductCollorTypeColorCategoryColor> ProductCollorTypeColorCategoryColor { get; set; }
        public virtual DbSet<ProductFont> ProductFont { get; set; }
        public virtual DbSet<ProductFontAlignment> ProductFontAlignment { get; set; }
        public virtual DbSet<ProductFontPrintingMethod> ProductFontPrintingMethod { get; set; }
        public virtual DbSet<ProductFontPrintingMethodColorCategory> ProductFontPrintingMethodColorCategory { get; set; }
        public virtual DbSet<ProductFontPrintingMethodColorCategoryColor> ProductFontPrintingMethodColorCategoryColor { get; set; }
        public virtual DbSet<ProductLogo> ProductLogo { get; set; }
        public virtual DbSet<ProductLogoPrintingMethod> ProductLogoPrintingMethod { get; set; }
        public virtual DbSet<ProductLogoPrintingMethodColorCategory> ProductLogoPrintingMethodColorCategory { get; set; }
        public virtual DbSet<ProductLogoPrintingMethodColorCategoryColor> ProductLogoPrintingMethodColorCategoryColor { get; set; }
        public virtual DbSet<ProductPattern> ProductPattern { get; set; }
        public virtual DbSet<ProductPatternSection> ProductPatternSection { get; set; }
        public virtual DbSet<ProductPatternSectionFabric> ProductPatternSectionFabric { get; set; }
        public virtual DbSet<ProductPatternSectionFabricColorCategory> ProductPatternSectionFabricColorCategory { get; set; }
        public virtual DbSet<ProductPatternSectionFabricColorCategoryColor> ProductPatternSectionFabricColorCategoryColor { get; set; }
        public virtual DbSet<ProductSku> ProductSku { get; set; }
        public virtual DbSet<ProductStyle> ProductStyle { get; set; }
        public virtual DbSet<Productbackup> Productbackup { get; set; }
        public virtual DbSet<ProjectSetting> ProjectSetting { get; set; }
        public virtual DbSet<RowMaster> RowMaster { get; set; }
        public virtual DbSet<SectionDetail> SectionDetail { get; set; }
        public virtual DbSet<SectionMaster> SectionMaster { get; set; }
        public virtual DbSet<ShelfMaster> ShelfMaster { get; set; }
        public virtual DbSet<ShelfRowDetail> ShelfRowDetail { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<TblColor> TblColor { get; set; }
        public virtual DbSet<TechnicalDocument> TechnicalDocument { get; set; }
        public virtual DbSet<Timezone> Timezone { get; set; }
        public virtual DbSet<UserConfiguration> UserConfiguration { get; set; }
        public virtual DbSet<UserModuleScreen> UserModuleScreen { get; set; }
        public virtual DbSet<UserReceivingNote> UserReceivingNote { get; set; }
        public virtual DbSet<UserReceivingNoteDetail> UserReceivingNoteDetail { get; set; }
        public virtual DbSet<UserStock> UserStock { get; set; }
        public virtual DbSet<UserStockLog> UserStockLog { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseAllocationDetail> WarehouseAllocationDetail { get; set; }
        public virtual DbSet<WmsfactoryUser> WmsfactoryUser { get; set; }
        public virtual DbSet<Wmsrole> Wmsrole { get; set; }
        public virtual DbSet<Wmsuser> Wmsuser { get; set; }
        public virtual DbSet<WmsuserAdditional> WmsuserAdditional { get; set; }
        public virtual DbSet<WmsuserAddress> WmsuserAddress { get; set; }
        public virtual DbSet<WmsuserClaim> WmsuserClaim { get; set; }
        public virtual DbSet<WmsuserLogin> WmsuserLogin { get; set; }
        public virtual DbSet<WmsuserRole> WmsuserRole { get; set; }
        public virtual DbSet<SpGetProductCategory> SpGetProductCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=xxx.xxx.xxx.xxx, 49725;Initial Catalog=TestDB;User Id=Custom;Password=Custom@1234;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandLogoSize>(entity =>
            {
                entity.ToTable("BrandLogoSize", "Consumer");

                entity.Property(e => e.CustomerId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Height).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSelected).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogoType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefCodeDisplay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color", "Master");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HexCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Pmscode)
                    .HasColumnName("PMSCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ColorCatagory>(entity =>
            {
                entity.ToTable("ColorCatagory", "Master");

                entity.Property(e => e.CatagoryDisplay)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CatagoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommunicationLog>(entity =>
            {
                entity.ToTable("CommunicationLog", "Dyo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.OrderEmblishmentId).HasColumnName("OrderEmblishmentID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SampleLogoId).HasColumnName("SampleLogoID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ConsumerFabric>(entity =>
            {
                entity.ToTable("ConsumerFabric", "Consumer");

                entity.Property(e => e.ConsumerFabricId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerFabricColor>(entity =>
            {
                entity.ToTable("ConsumerFabricColor", "Consumer");

                entity.Property(e => e.CheckUncheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.ColorCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HexCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pmscode)
                    .HasColumnName("PMSCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProduct>(entity =>
            {
                entity.ToTable("ConsumerProduct", "Consumer");

                entity.Property(e => e.ConsumerProductId).ValueGeneratedNever();

                entity.Property(e => e.ConsumerProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatternLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDconfig)
                    .HasColumnName("ThreeDConfig")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductCollarType>(entity =>
            {
                entity.ToTable("ConsumerProductCollarType", "Consumer");

                entity.Property(e => e.ConsumerProductCollarTypeId).ValueGeneratedNever();

                entity.Property(e => e.CollarIconPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CollarTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollarTypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerProductCollorTypeThumbnailPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBrandLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsButton).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCollar).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCollarStand).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCollarTape).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDrawcordTipClear).HasColumnName("IsDrawcordTip_Clear");

                entity.Property(e => e.IsNeckTape).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsZip).HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalMapFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedCollarType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecularMapFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDmodelObjFile)
                    .HasColumnName("ThreeDModelObjFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductCollarTypeDetail>(entity =>
            {
                entity.ToTable("ConsumerProductCollarTypeDetail", "Consumer");

                entity.Property(e => e.ConsumerProductCollarTypeDetailId).ValueGeneratedNever();

                entity.Property(e => e.CollarSection)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollarSectionCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollarSectionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SelectedCollarDetail).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductCollarTypeDetailFabric>(entity =>
            {
                entity.ToTable("ConsumerProductCollarTypeDetailFabric", "Consumer");

                entity.Property(e => e.ConsumerProductCollarTypeDetailFabricId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricWeight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductColor>(entity =>
            {
                entity.ToTable("ConsumerProductColor", "Consumer");

                entity.Property(e => e.ColorCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HexCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmscode)
                    .HasColumnName("PMSCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductCuff>(entity =>
            {
                entity.ToTable("ConsumerProductCuff", "Consumer");

                entity.Property(e => e.ConsumerProductCuffId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CuffDisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuffName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ThreeDname)
                    .HasColumnName("ThreeDName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductFabric>(entity =>
            {
                entity.ToTable("ConsumerProductFabric", "Consumer");

                entity.Property(e => e.ConsumerProductFabricId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricWeight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductFont>(entity =>
            {
                entity.ToTable("ConsumerProductFont", "Consumer");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FontCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FontName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedFont)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductLogo>(entity =>
            {
                entity.ToTable("ConsumerProductLogo", "Consumer");

                entity.Property(e => e.AdditionalInformation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoBase64).IsUnicode(false);

                entity.Property(e => e.LogoBytes).IsUnicode(false);

                entity.Property(e => e.LogoCheckBoxDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoEnableOrDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoPositionDisable).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogoType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoWidthDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoheightDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxHeight).HasMaxLength(50);

                entity.Property(e => e.MaxWidth).HasMaxLength(50);

                entity.Property(e => e.MinHeight).HasMaxLength(50);

                entity.Property(e => e.MinWidth).HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrintingMethodCheckOrUncheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemoveLogoShowOrHide).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedLogo).HasDefaultValueSql("((0))");

                entity.Property(e => e.TextUnderLogoCheckBoxDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.TextUnderLogoHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoHeightDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.TextUnderLogoIsAspectRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.TextUnderLogoMaxHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoMaxWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoMinHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoMinWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoShowOrHide).HasDefaultValueSql("((0))");

                entity.Property(e => e.TextUnderLogoWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoWidthDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadLogoShowOrHide).HasDefaultValueSql("((1))");

                entity.Property(e => e.Width)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsumerProductPattern>(entity =>
            {
                entity.ToTable("ConsumerProductPattern", "Consumer");

                entity.Property(e => e.BaseColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CbccheckBoxDisable)
                    .HasColumnName("CBCCheckBoxDisable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CbcheightDisable)
                    .HasColumnName("CBCHeightDisable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CbcnameAlignment)
                    .HasColumnName("CBCNameAlignment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameHeight)
                    .HasColumnName("CBCNameHeight")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameIsAspectRatio)
                    .HasColumnName("CBCNameIsAspectRatio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CbcnameMaxHeight)
                    .HasColumnName("CBCNameMaxHeight")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameMaxWidth)
                    .HasColumnName("CBCNameMaxWidth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameMinHeight)
                    .HasColumnName("CBCNameMinHeight")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameMinWidth)
                    .HasColumnName("CBCNameMinWidth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcnameWidth)
                    .HasColumnName("CBCNameWidth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cbcposition)
                    .HasColumnName("CBCPosition")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CbcpositionValue)
                    .HasColumnName("CBCPositionValue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CbcwidthDisable)
                    .HasColumnName("CBCWidthDisable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CollarColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CuffLeftColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CuffRightColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBrandLogoInsideNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCbcname)
                    .HasColumnName("IsCBCName")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTextInsideNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.MainColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameAlignment)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NameCheckBoxDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.NameHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameHeightDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.NameIsAspectRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameMaxHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameMaxWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameMinHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameMinWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamePosition)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NamePositionValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameWidthDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumberCheckBoxDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumberHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberHeightDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumberIsAspectRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumberMaxHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberMaxWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberMinHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberMinWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberPosition)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumberPositionValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumberWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberWidthDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.PattenIconFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatternCode)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatternImageFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatternName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuaternaryColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedCbcname)
                    .HasColumnName("SelectedCBCName")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedName).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.SelectedPattern)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedVerticalText).HasDefaultValueSql("((0))");

                entity.Property(e => e.Specification)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TertiaryColor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDpattern)
                    .HasColumnName("ThreeDPattern")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VerticalTextAlignment)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextCheckBoxDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.VerticalTextHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextHeightDisable).HasDefaultValueSql("((1))");

                entity.Property(e => e.VerticalTextIsAspectRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.VerticalTextMaxHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextMaxWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextMinHeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextMinWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextPositionValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextWidth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalTextWidthDisable).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ConsumerProductPatternSection>(entity =>
            {
                entity.ToTable("ConsumerProductPatternSection", "Consumer");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CuffChange)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductPatternSectionFabric>(entity =>
            {
                entity.HasKey(e => e.ConsumerFabricId);

                entity.ToTable("ConsumerProductPatternSectionFabric", "Consumer");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FabricWeight)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SelectedFabric)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductPrintingMethod>(entity =>
            {
                entity.ToTable("ConsumerProductPrintingMethod", "Consumer");

                entity.Property(e => e.ConsumerProductPrintingMethodName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedPrintingMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConsumerProductSection>(entity =>
            {
                entity.ToTable("ConsumerProductSection", "Consumer");

                entity.Property(e => e.ConsumerProductSectionId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "Master");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPhoneCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryPort>(entity =>
            {
                entity.ToTable("CountryPort", "Master");

                entity.Property(e => e.AirportPortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPort1)
                    .IsRequired()
                    .HasColumnName("CountryPort")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryPortBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CountryPortBackup", "Master");

                entity.Property(e => e.CountryPort)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPortId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CountryPortNewBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CountryPortNewBackup", "Master");

                entity.Property(e => e.AirportPortName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPortId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CreditTermLimit>(entity =>
            {
                entity.ToTable("CreditTermLimit", "Cust");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PaymentCurrency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerProduct>(entity =>
            {
                entity.ToTable("CustomerProduct", "Cust");

                entity.Property(e => e.BrandLogoFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LogoThumbnail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NumberHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDmodelObjFile)
                    .IsRequired()
                    .HasColumnName("ThreeDModelObjFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerUser>(entity =>
            {
                entity.ToTable("CustomerUser", "Cust");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DecorationMethod>(entity =>
            {
                entity.ToTable("DecorationMethod", "Master");

                entity.Property(e => e.DecorationMethodName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DelivieryMethod>(entity =>
            {
                entity.ToTable("DelivieryMethod", "Master");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DeliveryCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DelivieryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelivieryNameDisplay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignCollarType>(entity =>
            {
                entity.ToTable("DesignCollarType", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SelectedCollarType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCollarTypeDetail>(entity =>
            {
                entity.ToTable("DesignCollarTypeDetail", "NewDyo");

                entity.Property(e => e.CollarType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCollarTypeDetailFabric>(entity =>
            {
                entity.ToTable("DesignCollarTypeDetailFabric", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCollarTypeDetailFabricColor>(entity =>
            {
                entity.ToTable("DesignCollarTypeDetailFabricColor", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCuff>(entity =>
            {
                entity.ToTable("DesignCuff", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCuffSection>(entity =>
            {
                entity.ToTable("DesignCuffSection", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCuffSectionFabric>(entity =>
            {
                entity.ToTable("DesignCuffSectionFabric", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignCuffSectionFabricColor>(entity =>
            {
                entity.ToTable("DesignCuffSectionFabricColor", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPattern>(entity =>
            {
                entity.ToTable("DesignPattern", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternBrandLogo>(entity =>
            {
                entity.ToTable("DesignPatternBrandLogo", "NewDyo");

                entity.Property(e => e.AspectRatio).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogoBase64Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SizeRefCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignPatternBrandLogoPrintingMethod>(entity =>
            {
                entity.ToTable("DesignPatternBrandLogoPrintingMethod", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternBrandLogoPrintingMethodColor>(entity =>
            {
                entity.ToTable("DesignPatternBrandLogoPrintingMethodColor", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternFont>(entity =>
            {
                entity.ToTable("DesignPatternFont", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishMentTypePosition)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentTypePositionValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentTypeValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignPatternFontAlignment>(entity =>
            {
                entity.ToTable("DesignPatternFontAlignment", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayText)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectedFontAlignment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternFontPrintingMethod>(entity =>
            {
                entity.ToTable("DesignPatternFontPrintingMethod", "NewDyo");

                entity.Property(e => e.ConsumerProductPrintingMethodName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternFontPrintingMethodColor>(entity =>
            {
                entity.ToTable("DesignPatternFontPrintingMethodColor", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternFontPrintingMethodFont>(entity =>
            {
                entity.ToTable("DesignPatternFontPrintingMethodFont", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternLogo>(entity =>
            {
                entity.ToTable("DesignPatternLogo", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogoBase64Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogoCheckBoxDisable).HasColumnName("logoCheckBoxDisable");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignPatternLogoPrintingMethod>(entity =>
            {
                entity.ToTable("DesignPatternLogoPrintingMethod", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternLogoPrintingMethodColor>(entity =>
            {
                entity.ToTable("DesignPatternLogoPrintingMethodColor", "NewDyo");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternLogoTextUnderLogo>(entity =>
            {
                entity.ToTable("DesignPatternLogoTextUnderLogo", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TextUnderLogoValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesignPatternLogoTextUnderLogoPrintingMethod>(entity =>
            {
                entity.ToTable("DesignPatternLogoTextUnderLogoPrintingMethod", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternLogoTextUnderLogoPrintingMethodColor>(entity =>
            {
                entity.ToTable("DesignPatternLogoTextUnderLogoPrintingMethodColor", "NewDyo");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternLogoTextUnderLogoPrintingMethodFont>(entity =>
            {
                entity.ToTable("DesignPatternLogoTextUnderLogoPrintingMethodFont", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternSection>(entity =>
            {
                entity.ToTable("DesignPatternSection", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternSectionFabric>(entity =>
            {
                entity.ToTable("DesignPatternSectionFabric", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignPatternSectionFabricColor>(entity =>
            {
                entity.ToTable("DesignPatternSectionFabricColor", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DesignQuote>(entity =>
            {
                entity.ToTable("DesignQuote", "Dyo");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .IsClustered(false);

                entity.ToTable("ELMAH_Error");

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllXml).IsRequired();

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Fabric>(entity =>
            {
                entity.ToTable("Fabric", "Master");

                entity.Property(e => e.FabricDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FabricName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Font>(entity =>
            {
                entity.ToTable("Font", "Master");

                entity.Property(e => e.FontCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FontName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<LineMaster>(entity =>
            {
                entity.ToTable("LineMaster", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Logo>(entity =>
            {
                entity.ToTable("Logo", "LogoLibrary");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPublic).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogoCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogoCodePrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoHeight)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LogoImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogoNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogoThumbnail2Path)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogoThumbnailPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogoTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogoType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logowidth)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrintingImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrintingImageThumbnail2Path)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrintingImageThumbnailPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingApprovalUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TotalApprovalUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VectorImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VectorImageThumbnail2Path)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VectorImageThumbnailPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogoApproval>(entity =>
            {
                entity.ToTable("LogoApproval", "LogoLibrary");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsApprove).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogoCommunicationLog>(entity =>
            {
                entity.ToTable("LogoCommunicationLog", "LogoLibrary");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogoCustomColors>(entity =>
            {
                entity.ToTable("LogoCustomColors", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomColorType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomColorValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogoLibraryApprovalUser>(entity =>
            {
                entity.ToTable("LogoLibraryApprovalUser", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogoLibraryNotifyUser>(entity =>
            {
                entity.ToTable("LogoLibraryNotifyUser", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogoLibraryStrikeOffLogos>(entity =>
            {
                entity.HasKey(e => e.LogoLibraryId);

                entity.ToTable("LogoLibraryStrikeOffLogos", "LogoLibrary");

                entity.Property(e => e.LogoLibraryId).HasColumnName("LogoLibraryID");

                entity.Property(e => e.Logo).HasMaxLength(50);
            });

            modelBuilder.Entity<LogoStrikeOff>(entity =>
            {
                entity.ToTable("LogoStrikeOff", "LogoLibrary");

                entity.Property(e => e.LogoImage).HasMaxLength(50);
            });

            modelBuilder.Entity<LogoStrikeOffLogo>(entity =>
            {
                entity.ToTable("LogoStrikeOffLogo", "LogoLibrary");

                entity.Property(e => e.LogoStrikeOffLogoId).HasColumnName("LogoStrikeOffLogoID");

                entity.Property(e => e.LogoImage).HasMaxLength(50);
            });

            modelBuilder.Entity<MailBox>(entity =>
            {
                entity.ToTable("MailBox", "EmailSetting");

                entity.Property(e => e.BlindCopyRecipients)
                    .HasColumnName("Blind_Copy_Recipients")
                    .IsUnicode(false);

                entity.Property(e => e.CopyRecipients)
                    .HasColumnName("Copy_Recipients")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EnableSsl).HasColumnName("EnableSSL");

                entity.Property(e => e.ErrorLog).IsUnicode(false);

                entity.Property(e => e.FileAttachments)
                    .HasColumnName("File_Attachments")
                    .IsUnicode(false);

                entity.Property(e => e.MailBody)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MailSubject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpHost)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpPort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ModuleScreen>(entity =>
            {
                entity.ToTable("ModuleScreen", "Master");

                entity.Property(e => e.Class)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuleScreenDetail>(entity =>
            {
                entity.ToTable("ModuleScreenDetail", "Access");

                entity.Property(e => e.Class)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleScreenClass)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NumberofApproval>(entity =>
            {
                entity.ToTable("NumberofApproval", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TotalApprovalUser).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order", "Dyo");

                //entity.HasIndex(e => e.CustomerId).HasName("index_Order_CustomerId");

                entity.Property(e => e.ConfirmedExFactoryDate).HasColumnType("datetime");

                entity.Property(e => e.ConsumerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DispatchNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IsPickUpComplete).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobSheetFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobSheetShippingDetailFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PickupRequestedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedExFactoryDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedPickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderAddress>(entity =>
            {
                entity.ToTable("OrderAddress", "Dyo");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderAddressN>(entity =>
            {
                entity.ToTable("OrderAddressN", "NewDyo");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<OrderApprovalUser>(entity =>
            {
                entity.ToTable("OrderApprovalUser", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orderBackup", "Dyo");

                entity.Property(e => e.ConfirmedExFactoryDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DispatchNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.JobSheetFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobSheetShippingDetailFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PickupRequestedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedExFactoryDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedPickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderCarton>(entity =>
            {
                entity.ToTable("OrderCarton", "Dyo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CartonDisplayName).HasMaxLength(50);

                entity.Property(e => e.CartonNo).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<OrderCartonDetail>(entity =>
            {
                entity.ToTable("OrderCartonDetail", "Dyo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CartonId).HasColumnName("CartonID");

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUID");

                entity.HasOne(d => d.ProductSku)
                    .WithMany(p => p.OrderCartonDetail)
                    .HasForeignKey(d => d.ProductSkuid)
                    .HasConstraintName("FK_OrderCartonDetail_ProductSKU");
            });

            modelBuilder.Entity<OrderDesign>(entity =>
            {
                entity.ToTable("OrderDesign", "Dyo");

                entity.Property(e => e.ConsumerProductId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DesignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobSeetFile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobSeetImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PickFormFile)
                    .HasColumnName("PickFormFIle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductColor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImageThumb100X44)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImageThumb241X105)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImageThumb253X107)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImageThumb900X400)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDesignDetail>(entity =>
            {
                entity.ToTable("OrderDesignDetail", "Dyo");

                entity.Property(e => e.PickedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            });

            modelBuilder.Entity<OrderDesignN>(entity =>
            {
                entity.HasKey(e => e.OrderDesignId);

                entity.ToTable("OrderDesignN", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DesignName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobSeetFile)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobSeetImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PickFormFile)
                    .HasColumnName("PickFormFIle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductColor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesignImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDesignStyle>(entity =>
            {
                entity.ToTable("OrderDesignStyle", "Dyo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderEmblishment>(entity =>
            {
                entity.ToTable("OrderEmblishment", "Dyo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionUnit)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FontFamily)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsLogoFromLogoLibrary).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogoHeight).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LogoImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoThumbImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoWidth).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PrintMethod)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderEmblishmentDetail>(entity =>
            {
                entity.ToTable("OrderEmblishmentDetail", "Dyo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderFactoryUser>(entity =>
            {
                entity.ToTable("OrderFactoryUser", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderN>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderN", "NewDyo");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DispatchNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ExpectedDeliveryOnUtc).HasColumnType("datetime");

                entity.Property(e => e.JobSheetFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.JobSheetShippingDetailFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PickupRequestedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedPickupNoteFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderPickupDetail>(entity =>
            {
                entity.ToTable("OrderPickupDetail", "Dyo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUID");

                entity.Property(e => e.SectionDetailId).HasColumnName("SectionDetailID");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus", "Master");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Image)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDisplay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderStrikeOffLogos>(entity =>
            {
                entity.ToTable("OrderStrikeOffLogos", "Dyo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.OrderEmblishmentId).HasColumnName("OrderEmblishmentID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PrintingThumbImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderWareHouseUser>(entity =>
            {
                entity.ToTable("OrderWareHouseUser", "ExecutionPlan");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatternSectionColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatternSectionColor$");

                entity.Property(e => e.CollarColor).HasMaxLength(255);

                entity.Property(e => e.CuffLeftColor).HasMaxLength(255);

                entity.Property(e => e.CuffRightColor).HasMaxLength(255);

                entity.Property(e => e.MainColor).HasMaxLength(255);

                entity.Property(e => e.PatternCode).HasMaxLength(255);

                entity.Property(e => e.QuaternaryColor).HasMaxLength(255);

                entity.Property(e => e.SecondaryColor).HasMaxLength(255);

                entity.Property(e => e.TertiaryColor).HasMaxLength(255);
            });

            modelBuilder.Entity<PrintingMethod>(entity =>
            {
                entity.ToTable("PrintingMethod", "Master");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PrintingMethodName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Product");

                entity.Property(e => e.BrandLogoFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LogoThumbnail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NumberHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDmodelObjFile)
                    .IsRequired()
                    .HasColumnName("ThreeDModelObjFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductBrandLogo>(entity =>
            {
                entity.ToTable("ProductBrandLogo", "Product");

                entity.Property(e => e.BrandLogoPosition)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandLogoPositionDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductBrandLogoPrintingMethod>(entity =>
            {
                entity.ToTable("ProductBrandLogoPrintingMethod", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductBrandLogoPrintingMethodColorCategory>(entity =>
            {
                entity.ToTable("ProductBrandLogoPrintingMethodColorCategory", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductBrandLogoPrintingMethodColorCategoryColor>(entity =>
            {
                entity.ToTable("ProductBrandLogoPrintingMethodColorCategoryColor", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCatagory>(entity =>
            {
                entity.ToTable("ProductCatagory", "Master");

                //entity.HasIndex(e => e.CustomerId)
                //    .HasName("index_ProductCatagory_CustomerId");

                entity.Property(e => e.CatagoryDisplay)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CatagoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IconFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSelected).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductCategoryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCollarType>(entity =>
            {
                entity.ToTable("ProductCollarType", "Product");

                entity.Property(e => e.CollarTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBrandLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefaultCollarType).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNeckType).HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalMapFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCollorTypeThumbnailPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpecularMapFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDmodelObjFile)
                    .HasColumnName("ThreeDModelObjFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCollorTypeColorCategory>(entity =>
            {
                entity.ToTable("ProductCollorTypeColorCategory", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCollorTypeColorCategoryColor>(entity =>
            {
                entity.ToTable("ProductCollorTypeColorCategoryColor", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductFont>(entity =>
            {
                entity.ToTable("ProductFont", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FontName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductFontAlignment>(entity =>
            {
                entity.ToTable("ProductFontAlignment", "Product");

                entity.Property(e => e.AlignmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductFontPrintingMethod>(entity =>
            {
                entity.ToTable("ProductFontPrintingMethod", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductFontPrintingMethodColorCategory>(entity =>
            {
                entity.ToTable("ProductFontPrintingMethodColorCategory", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductFontPrintingMethodColorCategoryColor>(entity =>
            {
                entity.ToTable("ProductFontPrintingMethodColorCategoryColor", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductLogo>(entity =>
            {
                entity.ToTable("ProductLogo", "Product");

                entity.Property(e => e.AdditionalInformation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAspectRation).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogoMaxHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LogoMaxWidth).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LogoMinHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LogoMinWidth).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductLogoPrintingMethod>(entity =>
            {
                entity.ToTable("ProductLogoPrintingMethod", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductLogoPrintingMethodColorCategory>(entity =>
            {
                entity.ToTable("ProductLogoPrintingMethodColorCategory", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductLogoPrintingMethodColorCategoryColor>(entity =>
            {
                entity.ToTable("ProductLogoPrintingMethodColorCategoryColor", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPattern>(entity =>
            {
                entity.ToTable("ProductPattern", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PattenIconFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatternCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatternImageFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPatternSection>(entity =>
            {
                entity.ToTable("ProductPatternSection", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPatternSectionFabric>(entity =>
            {
                entity.ToTable("ProductPatternSectionFabric", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPatternSectionFabricColorCategory>(entity =>
            {
                entity.ToTable("ProductPatternSectionFabricColorCategory", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductPatternSectionFabricColorCategoryColor>(entity =>
            {
                entity.ToTable("ProductPatternSectionFabricColorCategoryColor", "Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefaultColor).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductSku>(entity =>
            {
                entity.ToTable("ProductSKU", "Product");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.FebricDescription).HasMaxLength(80);

                entity.Property(e => e.FebricNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hscode)
                    .HasColumnName("HSCode")
                    .HasMaxLength(80);

                entity.Property(e => e.OriginalJob).HasMaxLength(50);

                entity.Property(e => e.ProductDescription).HasMaxLength(80);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WeightUnit)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductStyle>(entity =>
            {
                entity.ToTable("ProductStyle", "Product");

                entity.Property(e => e.IsUploadLogo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleThumbnail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ThreeDstyleObj)
                    .IsRequired()
                    .HasColumnName("ThreeDStyleObj")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productbackup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BrandLogoFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LogoThumbnail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NumberHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThreeDmodelObjFile)
                    .IsRequired()
                    .HasColumnName("ThreeDModelObjFile")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectSetting>(entity =>
            {
                entity.ToTable("ProjectSetting", "Master");

                entity.Property(e => e.AppLogoPath).IsUnicode(false);

                entity.Property(e => e.AppTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiedText).HasMaxLength(100);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignQuotationEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaviconIconPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GovermentUrl)
                    .HasColumnName("GovermentURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredYear)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RowMaster>(entity =>
            {
                entity.ToTable("RowMaster", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<SectionDetail>(entity =>
            {
                entity.ToTable("SectionDetail", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShelfRowId).HasColumnName("ShelfRowID");

                entity.HasOne(d => d.ShelfRow)
                    .WithMany(p => p.SectionDetail)
                    .HasForeignKey(d => d.ShelfRowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionDetail_ShelfRowDetail");
            });

            modelBuilder.Entity<SectionMaster>(entity =>
            {
                entity.ToTable("SectionMaster", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<ShelfMaster>(entity =>
            {
                entity.ToTable("ShelfMaster", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<ShelfRowDetail>(entity =>
            {
                entity.ToTable("ShelfRowDetail", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ShelfId).HasColumnName("ShelfID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Master");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Size1)
                    .HasColumnName("size")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_color");

                entity.Property(e => e.ColorCategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerProductColorId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmblishmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HexCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pmscode)
                    .HasColumnName("PMSCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TechnicalDocument>(entity =>
            {
                entity.ToTable("TechnicalDocument", "LogoLibrary");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoId).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoTechnicalDocumentPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Timezone>(entity =>
            {
                entity.ToTable("Timezone", "Master");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Offset)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OffsetShort)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserConfiguration>(entity =>
            {
                entity.ToTable("UserConfiguration", "EmailSetting");

                entity.Property(e => e.EnableSsl)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FromMail)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MailHostName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regards)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpdisplayName)
                    .IsRequired()
                    .HasColumnName("SMTPDisplayName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Smtppassword)
                    .IsRequired()
                    .HasColumnName("SMTPPassword")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Smtpport)
                    .IsRequired()
                    .HasColumnName("SMTPport")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmtpuserName)
                    .IsRequired()
                    .HasColumnName("SMTPUserName")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SupportLink)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserModuleScreen>(entity =>
            {
                entity.ToTable("UserModuleScreen", "Access");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserReceivingNote>(entity =>
            {
                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.ReceivingNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserReceivingNoteDetail>(entity =>
            {
                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            });

            modelBuilder.Entity<UserStock>(entity =>
            {
                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserStockLog>(entity =>
            {
                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse", "Wms");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLatitude)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseAllocationDetail>(entity =>
            {
                entity.ToTable("WarehouseAllocationDetail", "Wms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUID");

                entity.Property(e => e.SectionDetailId).HasColumnName("SectionDetailID");
            });

            modelBuilder.Entity<WmsfactoryUser>(entity =>
            {
                entity.ToTable("WMSFactoryUser");

                entity.Property(e => e.WmsfactoryUserId).HasColumnName("WMSFactoryUserId");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wmsrole>(entity =>
            {
                entity.ToTable("WMSRole");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wmsuser>(entity =>
            {
                entity.ToTable("WMSUser");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastLoginOnUtc).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImage)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Skype)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<WmsuserAdditional>(entity =>
            {
                entity.ToTable("WMSUserAdditional");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.LogoCodePrefix).IsUnicode(false);

                entity.Property(e => e.PaymentCurrency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WmsuserAddress>(entity =>
            {
                entity.ToTable("WMSUserAddress");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WmsuserClaim>(entity =>
            {
                entity.ToTable("WMSUserClaim");
            });

            modelBuilder.Entity<WmsuserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_UserLogin_1");

                entity.ToTable("WMSUserLogin");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);
            });

            modelBuilder.Entity<WmsuserRole>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__WMSUserR__1788CC4CB415CB53");

                entity.ToTable("WMSUserRole");

                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpGetProductCategory>().HasNoKey();

            OnModelCreatingPartial(modelBuilder);

         
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //[Obsolete]
        //public async Task<List<SpGetProductCategory>> SP_GETProductCatefory()
        //{
        //    // Initialization.  
        //    List<SpGetProductCategory> lst = new List<SpGetProductCategory>();

        //    try
        //    {
        //        // Processing.  
        //        string sqlQuery = "EXEC [dbo].[SpGetProductCategory]";

        //        lst = await this.Query<SpGetProductCategory>().FromSql(sqlQuery).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    // Info.  
        //    return lst;
        //}

    }
}
