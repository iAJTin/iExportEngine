
namespace iTin.Export.Web
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    using Helper;

    /// <summary>
    /// Maps document extensions to content <strong>MIME</strong> types.
    /// </summary>
    /// <remarks>
    /// For more information please see <a href="http://www.freeformatter.com/mime-types-list.html">http://www.freeformatter.com/mime-types-list.html</a>
    /// </remarks>
    public static class MimeMapping
    {
        #region field static members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly KnownMimeMappingDictionary MappingDictionary = new KnownMimeMappingDictionary();
        #endregion

        #region public static methods

        #region [public] {static} (string) GetMimeMapping(string): Returns the MIME mapping for the specified file extension
        /// <summary>
        /// Returns the <strong>MIME</strong> mapping for the specified file extension.
        /// </summary>
        /// <param name="ext">The file extension that is used to determine the MIME type.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the <strong>MIME</strong> type.
        /// </returns>
        /// <example>
        /// The following code example, you get the mime type for pdf extension.
        /// <code lang="cs">
        ///   using System;   
        /// 
        ///   using iTin.Export.Web;
        /// 
        ///   class SampleClass   
        ///   {   
        ///       static int Main()   
        ///       {
        ///            // Gets the mime type.
        ///            string mime = MimeMapping.GetMimeMapping("pdf");
        /// 
        ///            // Print the result => 'application/pdf'
        ///            Console.WriteLine("MIME type for pdf extension is {0}", mime); 
        ///       }
        ///   }   
        ///  </code>
        /// </example>
        public static string GetMimeMapping(string ext)
        {
            SentinelHelper.ArgumentNull(ext);

            return MappingDictionary.GetMimeMappingFrom(ext);
        }
        #endregion

        #endregion


        #region private nested classes

        #region [class] KnownMimeMappingDictionary: Known document extensions to content MIME types
        /// <summary>
        /// Known document extensions to content MIME types.
        /// </summary>
        class KnownMimeMappingDictionary
        {
            #region field static members
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly Dictionary<string, string> mappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool isInitialized;
            #endregion

            #region public methods

            #region [public] (string) GetMimeMappingFrom(string): Returns the MIME mapping for the specified file extension
            /// <summary>
            /// Returns the MIME mapping for the specified file extension.
            /// </summary>
            /// <param name="ext">The file extension that is used to determine the MIME type.</param>
            /// <returns>
            /// <strong>MIME</strong> type.
            /// </returns>
            public string GetMimeMappingFrom(string ext)
            {
                SentinelHelper.ArgumentNull(ext);

                InitializeMapping();
                var extwithoutdot = ext.Replace(".", string.Empty);

                var hasMimeMapping = mappings.TryGetValue(extwithoutdot, out var mimeType);
                return hasMimeMapping ? mimeType : mappings["*"];
            }
            #endregion

            #endregion

            #region private methods

            #region [public] (void) InitializeMapping(): Initialize the mappings
            /// <summary>
            /// Initializes the mapping.
            /// </summary>
            private void InitializeMapping()
            {
                if (isInitialized)
                {
                    return;
                }

                lock (this)
                {
                    if (isInitialized)
                    {
                        return;
                    }

                    PopulateMappings();
                    isInitialized = true;
                }
            }
            #endregion

            #region [public] (void) PopulateMappings(): Populate known mappings
            /// <summary>
            /// Populate known mappings.
            /// </summary>
            [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
            private void PopulateMappings()
            {
                mappings.Add("*", "application/octet-stream");                                                     // Wildcard (Default)
                mappings.Add("x3d", "application/vnd.hzn-3d-crossword");                                           // 3D Crossword Plugin
                mappings.Add("3gp", "video/3gpp");                                                                 // 3GP
                mappings.Add("3g2", "video/3gpp2");                                                                // 3GP2
                mappings.Add("pwn", "application/vnd.3m.post-it-notes");                                           // 3M Post It Notes
                mappings.Add("plb", "application/vnd.3gpp.pic-bw-large");                                          // 3rd Generation Partnership Project - Pic Large
                mappings.Add("psb", "application/vnd.3gpp.pic-bw-small");                                          // 3rd Generation Partnership Project - Pic Small
                mappings.Add("pvb", "application/vnd.3gpp.pic-bw-var");                                            // 3rd Generation Partnership Project - Pic Var
                mappings.Add("tcap", "application/vnd.3gpp2.tcap");                                                // 3rd Generation Partnership Project - Transaction Capabilities Application Part
                mappings.Add("7z", "application/x-7z-compressed");                                                 // 7-Zip
                mappings.Add("abw", "application/x-abiword");                                                      // AbiWord
                mappings.Add("ace", "application/x-ace-compressed");                                               // Ace Archive
                mappings.Add("acc", "application/vnd.americandynamics.acc");                                       // Active Content Compression
                mappings.Add("acu", "application/vnd.acucobol");                                                   // ACU Cobol
                mappings.Add("atc", "application/vnd.acucorp");                                                    // ACU Cobol
                mappings.Add("adp", "audio/adpcm");                                                                // Adaptive differential pulse-code modulation
                mappings.Add("aab", "application/x-authorware-bin");                                               // Adobe (Macropedia) Authorware - Binary File
                mappings.Add("aam", "application/x-authorware-map");                                               // Adobe (Macropedia) Authorware - Map
                mappings.Add("aas", "application/x-authorware-seg");                                               // Adobe (Macropedia) Authorware - Segment File
                mappings.Add("air", "application/vnd.adobe.air-application-installer-package+zip");                // Adobe AIR Application
                mappings.Add("swf", "application/x-shockwave-flash");                                              // Adobe Flash
                mappings.Add("fxp", "application/vnd.adobe.fxp");                                                  // Adobe Flex Project
                mappings.Add("pdf", "application/pdf");                                                            // Adobe Portable Document
                mappings.Add("ppd", "application/vnd.cups-ppd");                                                   // Adobe PostScript Printer Description File Format
                mappings.Add("dir", "application/x-director");                                                     // Adobe Shockwave Player
                mappings.Add("xdp", "application/vnd.adobe.xdp+xml");                                              // Adobe XML Data Package
                mappings.Add("xfdf", "application/vnd.adobe.xfdf");                                                // Adobe XML Forms Data Format
                mappings.Add("aac", "audio/x-aac");                                                                // Advanced Audio Coding (AAC)
                mappings.Add("ahead", "application/vnd.ahead.space");                                              // Ahead AIR Application
                mappings.Add("azf", "application/vnd.airzip.filesecure.azf");                                      // AirZip FileSECURE
                mappings.Add("azs", "application/vnd.airzip.filesecure.azs");                                      // AirZip FileSECURE
                mappings.Add("azw", "application/vnd.amazon.ebook");                                               // Amazon Kindle eBook format
                mappings.Add("ami", "application/vnd.amiga.ami");                                                  // AmigaDE
                mappings.Add("apk", "application/vnd.android.package-archive");                                    // Android Package Archive
                mappings.Add("cii", "application/vnd.anser-web-certificate-issue-initiation");                     // ANSER-WEB Terminal Client - Certificate Issue
                mappings.Add("fti", "application/vnd.anser-web-funds-transfer-initiation");                        // ANSER-WEB Terminal Client - Web Funds Transfer
                mappings.Add("atx", "application/vnd.antix.game-component");                                       // Antix Game Player
                mappings.Add("mpkg", "application/vnd.apple.installer+xml");                                       // Apple Installer Package
                mappings.Add("aw", "application/applixware");                                                      // Applixware
                mappings.Add("les", "application/vnd.hhe.lesson-player");                                          // Archipelago Lesson Player
                mappings.Add("swi", "application/vnd.aristanetworks.swi");                                         // Arista Networks Software Image
                mappings.Add("s", "text/x-asm");                                                                   // Assembler Source File
                mappings.Add("atomcat", "application/atomcat+xml");                                                // Atom Publishing Protocol
                mappings.Add("atomsvc", "application/atomsvc+xml");                                                // Atom Publishing Protocol Service Document
                mappings.Add("atom", "application/atom+xml");                                                      // Atom Syndication Format
                mappings.Add("ac", "application/pkix-attr-cert");                                                  // Attribute Certificate
                mappings.Add("aif", "audio/x-aiff");                                                               // Audio Interchange File Format
                mappings.Add("avi", "video/x-msvideo");                                                            // Audio Video Interleave (AVI)
                mappings.Add("aep", "application/vnd.audiograph");                                                 // Audiograph
                mappings.Add("dxf", "image/vnd.dxf");                                                              // AutoCAD DXF
                mappings.Add("dwf", "model/vnd.dwf");                                                              // Autodesk Design Web Format (DWF)
                mappings.Add("par", "text/plain-bas");                                                             // BAS Partitur Format
                mappings.Add("bcpio", "application/x-bcpio");                                                      // Binary CPIO Archive
                mappings.Add("bin", "application/octet-stream");                                                   // Binary Data
                mappings.Add("bmp", "image/bmp");                                                                  // Bitmap Image File
                mappings.Add("torrent", "application/x-bittorrent");                                               // BitTorrent
                mappings.Add("cod", "application/vnd.rim.cod");                                                    // Blackberry COD File
                mappings.Add("mpm", "application/vnd.blueice.multipass");                                          // Blueice Research Multipass
                mappings.Add("bmi", "application/vnd.bmi");                                                        // BMI Drawing Data Interchange
                mappings.Add("sh", "application/x-sh");                                                            // Bourne Shell Script
                mappings.Add("btif", "image/prs.btif");                                                            // BTIF
                mappings.Add("rep", "application/vnd.businessobjects");                                            // BusinessObjects
                mappings.Add("bz", "application/x-bzip");                                                          // Bzip Archive
                mappings.Add("bz2", "application/x-bzip2");                                                        // Bzip2 Archive
                mappings.Add("csh", "application/x-csh");                                                          // C Shell Script
                mappings.Add("c", "text/x-c");                                                                     // C Source File
                mappings.Add("cdxml", "application/vnd.chemdraw+xml");                                             // CambridgeSoft Chem Draw
                mappings.Add("css", "text/css");                                                                   // Cascading Style Sheets (CSS)
                mappings.Add("cdx", "chemical/x-cdx");                                                             // ChemDraw eXchange file
                mappings.Add("cml", "chemical/x-cml");                                                             // Chemical Markup Language
                mappings.Add("csml", "chemical/x-csml");                                                           // Chemical Style Markup Language
                mappings.Add("cdbcmsg", "application/vnd.contact.cmsg");                                           // CIM Database
                mappings.Add("cla", "application/vnd.claymore");                                                   // Claymore Data Files
                mappings.Add("c4g", "application/vnd.clonk.c4group");                                              // Clonk Game
                mappings.Add("sub", "image/vnd.dvb.subtitle");                                                     // Close Captioning - Subtitle
                mappings.Add("cdmia", "application/cdmi-capability");                                              // Cloud Data Management Interface (CDMI) - Capability
                mappings.Add("cdmic", "application/cdmi-container");                                               // Cloud Data Management Interface (CDMI) - Contaimer
                mappings.Add("cdmid", "application/cdmi-domain");                                                  // Cloud Data Management Interface (CDMI) - Domain
                mappings.Add("cdmio", "application/cdmi-object");                                                  // Cloud Data Management Interface (CDMI) - Object
                mappings.Add("cdmiq", "application/cdmi-queue");                                                   // Cloud Data Management Interface (CDMI) - Queue
                mappings.Add("c11amc", "application/vnd.cluetrust.cartomobile-config");                            // ClueTrust CartoMobile - Config
                mappings.Add("c11amz", "application/vnd.cluetrust.cartomobile-config-pkg");                        // ClueTrust CartoMobile - Config Package
                mappings.Add("ras", "image/x-cmu-raster");                                                         // CMU Image
                mappings.Add("dae", "model/vnd.collada+xml");                                                      // COLLADA
                mappings.Add("csv", "text/csv");                                                                   // Comma-Seperated Values
                mappings.Add("cpt", "application/mac-compactpro");                                                 // Compact Pro
                mappings.Add("wmlc", "application/vnd.wap.wmlc");                                                  // Compiled Wireless Markup Language (WMLC)
                mappings.Add("cgm", "image/cgm");                                                                  // Computer Graphics Metafile
                mappings.Add("ice", "x-conference/x-cooltalk");                                                    // CoolTalk
                mappings.Add("cmx", "image/x-cmx");                                                                // Corel Metafile Exchange (CMX)
                mappings.Add("xar", "application/vnd.xara");                                                       // CorelXARA
                mappings.Add("cmc", "application/vnd.cosmocaller");                                                // CosmoCaller
                mappings.Add("cpio", "application/x-cpio");                                                        // CPIO Archive
                mappings.Add("clkx", "application/vnd.crick.clicker");                                             // CrickSoftware - Clicker
                mappings.Add("clkk", "application/vnd.crick.clicker.keyboard");                                    // CrickSoftware - Clicker - Keyboard
                mappings.Add("clkp", "application/vnd.crick.clicker.palette");                                     // CrickSoftware - Clicker - Palette
                mappings.Add("clkt", "application/vnd.crick.clicker.template");                                    // CrickSoftware - Clicker - Template
                mappings.Add("clkw", "application/vnd.crick.clicker.wordbank");                                    // CrickSoftware - Clicker - Wordbank
                mappings.Add("wbs", "application/vnd.criticaltools.wbs+xml");                                      // Critical Tools - PERT Chart EXPERT
                mappings.Add("cryptonote", "application/vnd.rig.cryptonote");                                      // CryptoNote
                mappings.Add("cif", "chemical/x-cif");                                                             // Crystallographic Interchange Format
                mappings.Add("cmdf", "chemical/x-cmdf");                                                           // CrystalMaker Data Format
                mappings.Add("cu", "application/cu-seeme");                                                        // CU-SeeMe
                mappings.Add("cww", "application/prs.cww");                                                        // CU-Writer
                mappings.Add("curl", "text/vnd.curl");                                                             // Curl - Applet
                mappings.Add("dcurl", "text/vnd.curl.dcurl");                                                      // Curl - Detached Applet
                mappings.Add("mcurl", "text/vnd.curl.mcurl");                                                      // Curl - Manifest File
                mappings.Add("scurl", "text/vnd.curl.scurl");                                                      // Curl - Source Code
                mappings.Add("car", "application/vnd.curl.car");                                                   // CURL Applet
                mappings.Add("pcurl", "application/vnd.curl.pcurl");                                               // CURL Applet
                mappings.Add("cmp", "application/vnd.yellowriver-custom-menu");                                    // CustomMenu
                mappings.Add("dssc", "application/dssc+der");                                                      // Data Structure for the Security Suitability of Cryptographic Algorithms
                mappings.Add("xdssc", "application/dssc+xml");                                                     // Data Structure for the Security Suitability of Cryptographic Algorithms
                mappings.Add("deb", "application/x-debian-package");                                               // Debian Package
                mappings.Add("uva", "audio/vnd.dece.audio");                                                       // DECE Audio
                mappings.Add("uvi", "image/vnd.dece.graphic");                                                     // DECE Graphic
                mappings.Add("uvh", "video/vnd.dece.hd");                                                          // DECE High Definition Video
                mappings.Add("uvm", "video/vnd.dece.mobile");                                                      // DECE Mobile Video
                mappings.Add("uvu", "video/vnd.uvvu.mp4");                                                         // DECE MP4
                mappings.Add("uvp", "video/vnd.dece.pd");                                                          // DECE PD Video
                mappings.Add("uvs", "video/vnd.dece.sd");                                                          // DECE SD Video
                mappings.Add("uvv", "video/vnd.dece.video");                                                       // DECE Video
                mappings.Add("dvi", "application/x-dvi");                                                          // Device Independent File Format (DVI)
                mappings.Add("seed", "application/vnd.fdsn.seed");                                                 // Digital Siesmograph Networks - SEED Datafiles
                mappings.Add("dtb", "application/x-dtbook+xml");                                                   // Digital Talking Book
                mappings.Add("res", "application/x-dtbresource+xml");                                              // Digital Talking Book - Resource File
                mappings.Add("ait", "application/vnd.dvb.ait");                                                    // Digital Video Broadcasting
                mappings.Add("svc", "application/vnd.dvb.service");                                                // Digital Video Broadcasting
                mappings.Add("eol", "audio/vnd.digital-winds");                                                    // Digital Winds Music
                mappings.Add("djvu", "image/vnd.djvu");                                                            // DjVu
                mappings.Add("dtd", "application/xml-dtd");                                                        // Document Type Definition
                mappings.Add("mlp", "application/vnd.dolby.mlp");                                                  // Dolby Meridian Lossless Packing
                mappings.Add("wad", "application/x-doom");                                                         // Doom Video Game
                mappings.Add("dpg", "application/vnd.dpgraph");                                                    // DPGraph
                mappings.Add("dra", "audio/vnd.dra");                                                              // DRA Audio
                mappings.Add("dfac", "application/vnd.dreamfactory");                                              // DreamFactory
                mappings.Add("dts", "audio/vnd.dts");                                                              // DTS Audio
                mappings.Add("dtshd", "audio/vnd.dts.hd");                                                         // DTS High Definition Audio
                mappings.Add("dwg", "image/vnd.dwg");                                                              // DWG Drawing
                mappings.Add("geo", "application/vnd.dynageo");                                                    // DynaGeo
                mappings.Add("es", "application/ecmascript");                                                      // ECMAScript
                mappings.Add("mag", "application/vnd.ecowin.chart");                                               // EcoWin Chart
                mappings.Add("mmr", "image/vnd.fujixerox.edmics-mmr");                                             // EDMICS 2000
                mappings.Add("rlc", "image/vnd.fujixerox.edmics-rlc");                                             // EDMICS 2000
                mappings.Add("exi", "application/exi");                                                            // Efficient XML Interchange
                mappings.Add("mgz", "application/vnd.proteus.magazine");                                           // EFI Proteus
                mappings.Add("epub", "application/epub+zip");                                                      // Electronic Publication
                mappings.Add("eml", "message/rfc822");                                                             // Email Message
                mappings.Add("nml", "application/vnd.enliven");                                                    // Enliven Viewer
                mappings.Add("mdb", "application/x-msaccess");                                                     // Microsoft Access
                mappings.Add("asf", "video/x-ms-asf");                                                             // Microsoft Advanced Systems Format (ASF)
                mappings.Add("exe", "application/x-msdownload");                                                   // Microsoft Application
                mappings.Add("cil", "application/vnd.ms-artgalry");                                                // Microsoft Artgalry
                mappings.Add("cab", "application/vnd.ms-cab-compressed");                                          // Microsoft Cabinet File
                mappings.Add("ims", "application/vnd.ms-ims");                                                     // Microsoft Class Server
                mappings.Add("application", "application/x-ms-application");                                       // Microsoft ClickOnce
                mappings.Add("clp", "application/x-msclip");                                                       // Microsoft Clipboard Clip
                mappings.Add("mdi", "image/vnd.ms-modi");                                                          // Microsoft Document Imaging Format
                mappings.Add("eot", "application/vnd.ms-fontobject");                                              // Microsoft Embedded OpenType
                mappings.Add("xls", "application/vnd.ms-excel");                                                   // Microsoft Excel
                mappings.Add("xlam", "application/vnd.ms-excel.addin.macroenabled.12");                            // Microsoft Excel - Add-In File
                mappings.Add("xlsb", "application/vnd.ms-excel.sheet.binary.macroenabled.12");                     // Microsoft Excel - Binary Workbook
                mappings.Add("xltm", "application/vnd.ms-excel.template.macroenabled.12");                         // Microsoft Excel - Macro-Enabled Template File
                mappings.Add("xlsm", "application/vnd.ms-excel.sheet.macroenabled.12");                            // Microsoft Excel - Macro-Enabled Workbook
                mappings.Add("chm", "application/vnd.ms-htmlhelp");                                                // Microsoft Html Help File                        
                mappings.Add("crd", "application/x-mscardfile");                                                   // Microsoft Information Card
                mappings.Add("lrm", "application/vnd.ms-lrm");                                                     // Microsoft Learning Resource Module
                mappings.Add("mvb", "application/x-msmediaview");                                                  // Microsoft MediaView
                mappings.Add("mny", "application/x-msmoney");                                                      // Microsoft Money
                mappings.Add("pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"); // Microsoft Office - OOXML - Presentation
                mappings.Add("sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide");        // Microsoft Office - OOXML - Presentation (Slide)
                mappings.Add("ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow");    // Microsoft Office - OOXML - Presentation (Slideshow)
                mappings.Add("potx", "application/vnd.openxmlformats-officedocument.presentationml.template");     // Microsoft Office - OOXML - Presentation Template
                mappings.Add("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");         // Microsoft Office - OOXML - Spreadsheet
                mappings.Add("xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template");      // Microsoft Office - OOXML - Spreadsheet Teplate
                mappings.Add("docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");   // Microsoft Office - OOXML - Word Document                                                
                mappings.Add("dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template");   // Microsoft Office - OOXML - Word Document Template
                mappings.Add("obd", "application/x-msbinder");                                                     // Microsoft Office Binder
                mappings.Add("thmx", "application/vnd.ms-officetheme");                                            // Microsoft Office System Release Theme
                mappings.Add("onetoc", "application/onenote");                                                     // Microsoft OneNote
                mappings.Add("pya", "audio/vnd.ms-playready.media.pya");                                           // Microsoft PlayReady Ecosystem
                mappings.Add("pyv", "video/vnd.ms-playready.media.pyv");                                           // Microsoft PlayReady Ecosystem Video
                mappings.Add("ppt", "application/vnd.ms-powerpoint");                                              // Microsoft PowerPoint
                mappings.Add("ppam", "application/vnd.ms-powerpoint.addin.macroenabled.12");                       // Microsoft PowerPoint - Add-in file
                mappings.Add("sldm", "application/vnd.ms-powerpoint.slide.macroenabled.12");                       // Microsoft PowerPoint - Macro-Enabled Open XML Slide
                mappings.Add("pptm", "application/vnd.ms-powerpoint.presentation.macroenabled.12");                // Microsoft PowerPoint - Macro-Enabled Presentation File
                mappings.Add("ppsm", "application/vnd.ms-powerpoint.slideshow.macroenabled.12");                   // Microsoft PowerPoint - Macro-Enabled Slide Show File
                mappings.Add("mpp", "application/vnd.ms-project");                                                 // Microsoft Project
                mappings.Add("pub", "application/x-mspublisher");                                                  // Microsoft Publisher
                mappings.Add("scd", "application/x-msschedule");                                                   // Microsoft Schedule+
                mappings.Add("xap", "application/x-silverlight-app");                                              // Microsoft Silverlight
                mappings.Add("stl", "application/vnd.ms-pki.stl");                                                 // Microsoft Trust UI Provider - Certificate Trust Link
                mappings.Add("cat", "application/vnd.ms-pki.seccat");                                              // Microsoft Trust UI Provider - Security Catalog
                mappings.Add("vsd", "application/vnd.visio");                                                      // Microsoft Visio
                mappings.Add("wm", "video/x-ms-wm");                                                               // Microsoft Windows Media
                mappings.Add("wma", "audio/x-ms-wma");                                                             // Microsoft Windows Media Audio
                mappings.Add("wax", "audio/x-ms-wax");                                                             // Microsoft Windows Media Audio Redirector                     
                mappings.Add("wmx", "video/x-ms-wmx");                                                             // Microsoft Windows Media Audio/Video Playlist
                mappings.Add("wmd", "application/x-ms-wmd");                                                       // Microsoft Windows Media Player Download Package
                mappings.Add("wpl", "application/vnd.ms-wpl");                                                     // Microsoft Windows Media Player Playlist
                mappings.Add("wmz", "application/x-ms-wmz");                                                       // Microsoft Windows Media Player Skin Package
                mappings.Add("wmv", "video/x-ms-wmv");                                                             // Microsoft Windows Media Video
                mappings.Add("wvx", "video/x-ms-wvx");                                                             // Microsoft Windows Media Video Playlist
                mappings.Add("wmf", "application/x-msmetafile");                                                   // Microsoft Windows Metafile
                mappings.Add("trm", "application/x-msterminal");                                                   // Microsoft Windows Terminal Services
                mappings.Add("doc", "application/msword");                                                         // Microsoft Word
                mappings.Add("wri", "application/x-mswrite");                                                      // Microsoft Wordpad
                mappings.Add("wps", "application/vnd.ms-works");                                                   // Microsoft Works
                mappings.Add("xbap", "application/x-ms-xbap");                                                     // Microsoft XAML Browser Application
                mappings.Add("xps", "application/vnd.ms-xpsdocument");                                             // Microsoft XML Paper Specification                      
                mappings.Add("potm", "application/vnd.ms-powerpoint.template.macroenabled.12");                    // Micosoft PowerPoint - Macro-Enabled Template File 
                mappings.Add("docm", "application/vnd.ms-word.document.macroenabled.12");                          // Micosoft Word - Macro-Enabled Document
                mappings.Add("dotm", "application/vnd.ms-word.template.macroenabled.12");                          // Micosoft Word - Macro-Enabled Template                     
                mappings.Add("h261", "video/h261");                                                                // H.261
                mappings.Add("h263", "video/h263");                                                                // H.263
                mappings.Add("h264", "video/h264");                                                                // H.264
                mappings.Add("odc", "application/vnd.oasis.opendocument.chart");                                   // OpenDocument Chart
                mappings.Add("otc", "application/vnd.oasis.opendocument.chart-template");                          // OpenDocument Chart Template
                mappings.Add("odb", "application/vnd.oasis.opendocument.database");                                // OpenDocument Database
                mappings.Add("odf", "application/vnd.oasis.opendocument.formula");                                 // OpenDocument Formula
                mappings.Add("odft", "application/vnd.oasis.opendocument.formula-template");                       // OpenDocument Formula Template
                mappings.Add("odg", "application/vnd.oasis.opendocument.graphics");                                // OpenDocument Graphics
                mappings.Add("otg", "application/vnd.oasis.opendocument.graphics-template");                       // OpenDocument Graphics Template
                mappings.Add("odi", "application/vnd.oasis.opendocument.image");                                   // OpenDocument Image
                mappings.Add("oti", "application/vnd.oasis.opendocument.image-template");                          // OpenDocument Image Template
                mappings.Add("odp", "application/vnd.oasis.opendocument.presentation");                            // OpenDocument Presentation
                mappings.Add("otp", "application/vnd.oasis.opendocument.presentation-template");                   // OpenDocument Presentation Template
                mappings.Add("ods", "application/vnd.oasis.opendocument.spreadsheet");                             // OpenDocument Spreadsheet
                mappings.Add("ots", "application/vnd.oasis.opendocument.spreadsheet-template");                    // OpenDocument Spreadsheet Template
                mappings.Add("odt", "application/vnd.oasis.opendocument.text");                                    // OpenDocument Text
                mappings.Add("odm", "application/vnd.oasis.opendocument.text-master");                             // OpenDocument Text Master
                mappings.Add("ott", "application/vnd.oasis.opendocument.text-template");                           // OpenDocument Text Template
                mappings.Add("ktx", "image/ktx");                                                                  // OpenGL Textures (KTX)
                mappings.Add("sxc", "application/vnd.sun.xml.calc");                                               // OpenOffice - Calc (Spreadsheet)
                mappings.Add("stc", "application/vnd.sun.xml.calc.template");                                      // OpenOffice - Calc Template (Spreadsheet)
                mappings.Add("sxd", "application/vnd.sun.xml.draw");                                               // OpenOffice - Draw (Graphics)
                mappings.Add("std", "application/vnd.sun.xml.draw.template");                                      // OpenOffice - Draw Template (Graphics)
                mappings.Add("sxi", "application/vnd.sun.xml.impress");                                            // OpenOffice - Impress (Presentation)
                mappings.Add("sti", "application/vnd.sun.xml.impress.template");                                   // OpenOffice - Impress Template (Presentation)
                mappings.Add("sxm", "application/vnd.sun.xml.math");                                               // OpenOffice - Math (Formula)
                mappings.Add("sxw", "application/vnd.sun.xml.writer");                                             // OpenOffice - Writer (Text - HTML)
                mappings.Add("sxg", "application/vnd.sun.xml.writer.global");                                      // OpenOffice - Writer (Text - HTML)
                mappings.Add("stw", "application/vnd.sun.xml.writer.template");                                    // OpenOffice - Writer Template (Text - HTML)
                mappings.Add("otf", "application/x-font-otf");                                                     // OpenType Font File
                mappings.Add("mj2", "video/mj2");                                                                  // Motion JPEG 2000
                mappings.Add("mpga", "audio/mpeg");                                                                // MPEG Audio
                mappings.Add("mxu", "video/vnd.mpegurl");                                                          // MPEG Url
                mappings.Add("mpeg", "video/mpeg");                                                                // MPEG Video
                mappings.Add("m21", "application/mp21");                                                           // MPEG-21
                mappings.Add("mp4a", "audio/mp4");                                                                 // MPEG-4 Audio
                mappings.Add("mp4", "video/mp4");                                                                  // MPEG-4 Video
                mappings.Add("tex", "application/x-tex");                                                          // TeX
                mappings.Add("tfm", "application/x-tex-tfm");                                                      // TeX Font Metric
                mappings.Add("tei", "application/tei+xml");                                                        // Text Encoding and Interchange
                mappings.Add("txt", "text/plain");                                                                 // Text File
                mappings.Add("xpr", "application/vnd.is-xpr");                                                     // Express by Infoseek
                mappings.Add("xif", "image/vnd.xiff");                                                             // eXtended Image File Format (XIFF)
                mappings.Add("xfdl", "application/vnd.xfdl");                                                      // Extensible Forms Description Language
                mappings.Add("emma", "application/emma+xml");                                                      // Extensible MultiModal Annotation
                mappings.Add("ez2", "application/vnd.ezpix-album");                                                // EZPix Secure Photo Album
                mappings.Add("ez3", "application/vnd.ezpix-package");                                              // EZPix Secure Photo Album
                mappings.Add("fst", "image/vnd.fst");                                                              // FAST Search & Transfer ASA
                mappings.Add("fvt", "video/vnd.fvt");                                                              // FAST Search & Transfer ASA
                mappings.Add("fbs", "image/vnd.fastbidsheet");                                                     // FastBid Sheet
                mappings.Add("fe_launch", "application/vnd.denovo.fcselayout-link");                               // FCS Express Layout Link
                mappings.Add("f4v", "video/x-f4v");                                                                // Flash Video
                mappings.Add("flv", "video/x-flv");                                                                // Flash Video
                mappings.Add("fpx", "image/vnd.fpx");                                                              // FlashPix
                mappings.Add("npx", "image/vnd.net-fpx");                                                          // FlashPix
                mappings.Add("flx", "text/vnd.fmi.flexstor");                                                      // FLEXSTOR
                mappings.Add("fli", "video/x-fli");                                                                // FLI/FLC Animation Format
                mappings.Add("ftc", "application/vnd.fluxtime.clip");                                              // FluxTime Clip
                mappings.Add("fdf", "application/vnd.fdf");                                                        // Forms Data Format
                mappings.Add("f", "text/x-fortran");                                                               // Fortran Source File
                mappings.Add("mif", "application/vnd.mif");                                                        // FrameMaker Interchange Format
                mappings.Add("fm", "application/vnd.framemaker");                                                  // FrameMaker Normal Format
                mappings.Add("fh", "image/x-freehand");                                                            // FreeHand MX
                mappings.Add("fsc", "application/vnd.fsc.weblaunch");                                              // Friendly Software Corporation
                mappings.Add("fnc", "application/vnd.frogans.fnc");                                                // Frogans Player
                mappings.Add("ltf", "application/vnd.frogans.ltf");                                                // Frogans Player
                mappings.Add("ddd", "application/vnd.fujixerox.ddd");                                              // Fujitsu - Xerox 2D CAD Data
                mappings.Add("xdw", "application/vnd.fujixerox.docuworks");                                        // Fujitsu - Xerox DocuWorks
                mappings.Add("xbd", "application/vnd.fujixerox.docuworks.binder");                                 // Fujitsu - Xerox DocuWorks Binder
                mappings.Add("oas", "application/vnd.fujitsu.oasys");                                              // Fujitsu Oasys
                mappings.Add("oa2", "application/vnd.fujitsu.oasys2");                                             // Fujitsu Oasys
                mappings.Add("oa3", "application/vnd.fujitsu.oasys3");                                             // Fujitsu Oasys
                mappings.Add("fg5", "application/vnd.fujitsu.oasysgp");                                            // Fujitsu Oasys
                mappings.Add("bh2", "application/vnd.fujitsu.oasysprs");                                           // Fujitsu Oasys
                mappings.Add("spl", "application/x-futuresplash");                                                 // FutureSplash Animator
                mappings.Add("fzs", "application/vnd.fuzzysheet");                                                 // FuzzySheet
                mappings.Add("g3", "image/g3fax");                                                                 // G3 Fax Image
                mappings.Add("gmx", "application/vnd.gmx");                                                        // GameMaker ActiveX
                mappings.Add("gtw", "model/vnd.gtw");                                                              // Gen-Trix Studio
                mappings.Add("txd", "application/vnd.genomatix.tuxedo");                                           // Genomatix Tuxedo Framework
                mappings.Add("ggb", "application/vnd.geogebra.file");                                              // GeoGebra
                mappings.Add("ggt", "application/vnd.geogebra.tool");                                              // GeoGebra
                mappings.Add("gdl", "model/vnd.gdl");                                                              // Geometric Description Language (GDL)
                mappings.Add("gex", "application/vnd.geometry-explorer");                                          // GeoMetry Explorer
                mappings.Add("gxt", "application/vnd.geonext");                                                    // GEONExT and JSXGraph
                mappings.Add("g2w", "application/vnd.geoplan");                                                    // GeoplanW
                mappings.Add("g3w", "application/vnd.geospace");                                                   // GeospacW
                mappings.Add("gsf", "application/x-font-ghostscript");                                             // Ghostscript Font
                mappings.Add("bdf", "application/x-font-bdf");                                                     // Glyph Bitmap Distribution Format
                mappings.Add("gtar", "application/x-gtar");                                                        // GNU Tar Files
                mappings.Add("texinfo", "application/x-texinfo");                                                  // GNU Texinfo Document
                mappings.Add("gnumeric", "application/x-gnumeric");                                                // Gnumeric
                mappings.Add("kml", "application/vnd.google-earth.kml+xml");                                       // Google Earth - KML
                mappings.Add("kmz", "application/vnd.google-earth.kmz");                                           // Google Earth - Zipped KML
                mappings.Add("gqf", "application/vnd.grafeq");                                                     // GrafEq
                mappings.Add("gif", "image/gif");                                                                  // Graphics Interchange Format
                mappings.Add("gv", "text/vnd.graphviz");                                                           // Graphviz
                mappings.Add("gac", "application/vnd.groove-account");                                             // Groove - Account
                mappings.Add("ghf", "application/vnd.groove-help");                                                // Groove - Help
                mappings.Add("gim", "application/vnd.groove-identity-message");                                    // Groove - Identity Message
                mappings.Add("grv", "application/vnd.groove-injector");                                            // Groove - Injector
                mappings.Add("gtm", "application/vnd.groove-tool-message");                                        // Groove - Tool Message
                mappings.Add("tpl", "application/vnd.groove-tool-template");                                       // Groove - Tool Template
                mappings.Add("vcg", "application/vnd.groove-vcard");                                               // Groove - Vcard
                mappings.Add("hpid", "application/vnd.hp-hpid");                                                   // Hewlett Packard Instant Delivery
                mappings.Add("hps", "application/vnd.hp-hps");                                                     // Hewlett-Packard's WebPrintSmart Hierarchical Data Format
                mappings.Add("hdf", "application/x-hdf");                                                          // Hierarchical Data Format
                mappings.Add("rip", "audio/vnd.rip");                                                              // Hit'n'Mix
                mappings.Add("hbci", "application/vnd.hbci");                                                      // Homebanking Computer Interface (HBCI)
                mappings.Add("jlt", "application/vnd.hp-jlyt");                                                    // HP Indigo Digital Press - Job Layout Languate
                mappings.Add("pcl", "application/vnd.hp-pcl");                                                     // HP Printer Command Language
                mappings.Add("hpgl", "application/vnd.hp-hpgl");                                                   // HP-GL/2 and HP RTL
                mappings.Add("hvs", "application/vnd.yamaha.hv-script");                                           // HV Script
                mappings.Add("hvd", "application/vnd.yamaha.hv-dic");                                              // HV Voice Dictionary
                mappings.Add("hvp", "application/vnd.yamaha.hv-voice");                                            // HV Voice Parameter
                mappings.Add("sfd-hdstx", "application/vnd.hydrostatix.sof-data");                                 // Hydrostatix Master Suite
                mappings.Add("stk", "application/hyperstudio");                                                    // Hyperstudio
                mappings.Add("hal", "application/vnd.hal+xml");                                                    // Hypertext Application Language
                mappings.Add("html", "text/html");                                                                 // HyperText Markup Language (HTML)
                mappings.Add("irm", "application/vnd.ibm.rights-management");                                      // IBM DB2 Rights Manager
                mappings.Add("sc", "application/vnd.ibm.secure-container");                                        // IBM Electronic Media Management System - Secure Container
                mappings.Add("ics", "text/calendar");                                                              // iCalendar
                mappings.Add("icc", "application/vnd.iccprofile");                                                 // ICC profile
                mappings.Add("ico", "image/x-icon");                                                               // Icon Image
                mappings.Add("igl", "application/vnd.igloader");                                                   // igLoader
                mappings.Add("ief", "image/ief");                                                                  // Image Exchange Format
                mappings.Add("ivp", "application/vnd.immervision-ivp");                                            // ImmerVision PURE Players
                mappings.Add("ivu", "application/vnd.immervision-ivu");                                            // ImmerVision PURE Players
                mappings.Add("rif", "application/reginfo+xml");                                                    // IMS Networks
                mappings.Add("3dml", "text/vnd.in3d.3dml");                                                        // In3D - 3DML
                mappings.Add("spot", "text/vnd.in3d.spot");                                                        // In3D - 3DML
                mappings.Add("igs", "model/iges");                                                                 // Initial Graphics Exchange Specification (IGES)
                mappings.Add("i2g", "application/vnd.intergeo");                                                   // Interactive Geometry Software
                mappings.Add("cdy", "application/vnd.cinderella");                                                 // Interactive Geometry Software Cinderella
                mappings.Add("xpw", "application/vnd.intercon.formnet");                                           // Intercon FormNet
                mappings.Add("fcs", "application/vnd.isac.fcs");                                                   // International Society for Advancement of Cytometry
                mappings.Add("ipfix", "application/ipfix");                                                        // Internet Protocol Flow Information Export
                mappings.Add("cer", "application/pkix-cert");                                                      // Internet Public Key Infrastructure - Certificate
                mappings.Add("pki", "application/pkixcmp");                                                        // Internet Public Key Infrastructure - Certificate Management Protocole
                mappings.Add("crl", "application/pkix-crl");                                                       // Internet Public Key Infrastructure - Certificate Revocation Lists
                mappings.Add("pkipath", "application/pkix-pkipath");                                               // Internet Public Key Infrastructure - Certification Path
                mappings.Add("igm", "application/vnd.insors.igm");                                                 // IOCOM Visimeet
                mappings.Add("rcprofile", "application/vnd.ipunplugged.rcprofile");                                // IP Unplugged Roaming Client
                mappings.Add("irp", "application/vnd.irepository.package+xml");                                    // iRepository / Lucidoc Editor
                mappings.Add("jad", "text/vnd.sun.j2me.app-descriptor");                                           // J2ME App Descriptor
                mappings.Add("jar", "application/java-archive");                                                   // Java Archive
                mappings.Add("class", "application/java-vm");                                                      // Java Bytecode File
                mappings.Add("jnlp", "application/x-java-jnlp-file");                                              // Java Network Launching Protocol
                mappings.Add("ser", "application/java-serialized-object");                                         // Java Serialized Object
                mappings.Add("java", "text/x-java-source,java");                                                   // Java Source File
                mappings.Add("js", "application/javascript");                                                      // JavaScript
                mappings.Add("json", "application/json");                                                          // JavaScript Object Notation (JSON)
                mappings.Add("joda", "application/vnd.joost.joda-archive");                                        // Joda Archive
                mappings.Add("jpm", "video/jpm");                                                                  // JPEG 2000 Compound Image File Format
                mappings.Add("jpg", "image/jpg");                                                                  // JPEG Image
                mappings.Add("jpeg", "image/jpeg");                                                                // JPEG Image
                mappings.Add("jpgv", "video/jpeg");                                                                // JPGVideo
                mappings.Add("ktz", "application/vnd.kahootz");                                                    // Kahootz
                mappings.Add("sql", "application/x-sql");                                                          // Sql file
                mappings.Add("mmd", "application/vnd.chipnuts.karaoke-mmd");                                       // Karaoke on Chipnuts Chipsets
                mappings.Add("karbon", "application/vnd.kde.karbon");                                              // KDE KOffice Office Suite - Karbon
                mappings.Add("chrt", "application/vnd.kde.kchart");                                                // KDE KOffice Office Suite - KChart
                mappings.Add("kfo", "application/vnd.kde.kformula");                                               // KDE KOffice Office Suite - Kformula
                mappings.Add("flw", "application/vnd.kde.kivio");                                                  // KDE KOffice Office Suite - Kivio
                mappings.Add("kon", "application/vnd.kde.kontour");                                                // KDE KOffice Office Suite - Kontour
                mappings.Add("kpr", "application/vnd.kde.kpresenter");                                             // KDE KOffice Office Suite - Kpresenter
                mappings.Add("ksp", "application/vnd.kde.kspread");                                                // KDE KOffice Office Suite - Kspread
                mappings.Add("kwd", "application/vnd.kde.kword");                                                  // KDE KOffice Office Suite - Kword
                mappings.Add("123", "application/vnd.lotus-1-2-3");                                                // Lotus 1-2-3
                mappings.Add("apr", "application/vnd.lotus-approach");                                             // Lotus Approach
                mappings.Add("pre", "application/vnd.lotus-freelance");                                            // Lotus Freelance
                mappings.Add("nsf", "application/vnd.lotus-notes");                                                // Lotus Notes
                mappings.Add("org", "application/vnd.lotus-organizer");                                            // Lotus Organizer
                mappings.Add("scm", "application/vnd.lotus-screencam");                                            // Lotus Screencam
                mappings.Add("lwp", "application/vnd.lotus-wordpro");                                              // Lotus Wordpro
                mappings.Add("oda", "application/oda");                                                            // Office Document Architecture
                mappings.Add("ogx", "application/ogg");                                                            // Ogg
                mappings.Add("oga", "audio/ogg");                                                                  // Ogg Audio
                mappings.Add("ogv", "video/ogg");                                                                  // Ogg Video
                mappings.Add("dd2", "application/vnd.oma.dd2+xmlg");                                               // OMA Download Agents
                mappings.Add("oth", "application/vnd.oasis.opendocument.text-web");                                // Open Document Text Web
                mappings.Add("opf", "application/oebps-package+xml");                                              // Open eBook Publication Structure
                mappings.Add("qbo", "application/vnd.intu.qbo");                                                   // Open Financial Exchange
                mappings.Add("oxt", "application/vnd.openofficeorg.extension");                                    // Open Office Extension
                mappings.Add("osf", "application/vnd.yamaha.openscoreformat");                                     // Open Score Format
                mappings.Add("weba", "audio/webm");                                                                // Open Web Media Project - Audio
                mappings.Add("webm", "video/webm");                                                                // Open Web Media Project - Video
                mappings.Add("osfpvg", "application/vnd.yamaha.openscoreformat.osfpvg+xml");                       // OSFPVG
                mappings.Add("dp", "application/vnd.osgi.dp");                                                     // OSGi Deployment Package
                mappings.Add("pdb", "application/vnd.palm");                                                       // PalmOS Data
                mappings.Add("p", "text/x-pascal");                                                                // Pascal Source File
                mappings.Add("pnm", "image/x-portable-anymap");                                                    // Portable Anymap Image
                mappings.Add("pbm", "image/x-portable-bitmap");                                                    // Portable Bitmap Format
                mappings.Add("pcf", "application/x-font-pcf");                                                     // Portable Compiled Format
                mappings.Add("pfr", "application/font-tdpfr");                                                     // Portable Font Resource
                mappings.Add("pgn", "application/x-chess-pgn");                                                    // Portable Game Notation (Chess Games)
                mappings.Add("pgm", "image/x-portable-graymap");                                                   // Portable Graymap Format
                mappings.Add("png", "image/png");                                                                  // Portable Network Graphics (PNG)
                mappings.Add("ppm", "image/x-portable-pixmap");                                                    // Portable Pixmap Format
                mappings.Add("pskcxml", "application/pskc+xml");                                                   // Portable Symmetric Key Container
                mappings.Add("pml", "application/vnd.ctc-posml");                                                  // PosML
                mappings.Add("ai", "application/postscript");                                                      // PostScript
                mappings.Add("pfa", "application/x-font-type1");                                                   // PostScript Fonts
                mappings.Add("pbd", "application/vnd.powerbuilder6");                                              // PowerBuilder
                mappings.Add("qfx", "application/vnd.intu.qfx");                                                   // Quicken
                mappings.Add("qt", "video/quicktime");                                                             // Quicktime Video
                mappings.Add("rar", "application/x-rar-compressed");                                               // RAR Archive
                mappings.Add("ram", "audio/x-pn-realaudio");                                                       // Real Audio Sound
                mappings.Add("rmp", "audio/x-pn-realaudio-plugin");                                                // Real Audio Sound
                mappings.Add("rsd", "application/rsd+xml");                                                        // Really Simple Discovery
                mappings.Add("rm", "application/vnd.rn-realmedia");                                                // RealMedia
                mappings.Add("bed", "application/vnd.realvnc.bed");                                                // RealVNC
                mappings.Add("sgml", "text/sgml");                                                                 // Standard Generalized Markup Language (SGML)
                mappings.Add("sdc", "application/vnd.stardivision.calc");                                          // StarOffice - Calc
                mappings.Add("sda", "application/vnd.stardivision.draw");                                          // StarOffice - Draw
                mappings.Add("sdd", "application/vnd.stardivision.impress");                                       // StarOffice - Impress
                mappings.Add("smf", "application/vnd.stardivision.math");                                          // StarOffice - Math
                mappings.Add("sdw", "application/vnd.stardivision.writer");                                        // StarOffice - Writer
                mappings.Add("sgl", "application/vnd.stardivision.writer-global");                                 // StarOffice - Writer (Global)
                mappings.Add("rtf", "application/rtf");                                                            // Rich Text Format
                mappings.Add("rtx", "text/richtext");                                                              // Rich Text Format (RTF)
                mappings.Add("sis", "application/vnd.symbian.install");                                            // Symbian Install Package     
                mappings.Add("vbs", "text/vbscript");                                                              // Visual Basic Script
                mappings.Add("vcd", "application/x-cdlink");                                                       // Video CD
                mappings.Add("src", "application/x-wais-source");                                                  // WAIS Source
                mappings.Add("wbxml", "application/vnd.wap.wbxml");                                                // WAP Binary XML (WBXML)
                mappings.Add("wbmp", "image/vnd.wap.wbmp");                                                        // WAP Bitamp (WBMP)
                mappings.Add("wav", "audio/x-wav");                                                                // Waveform Audio File Format (WAV)
                mappings.Add("davmount", "application/davmount+xml");                                              // Web Distributed Authoring and Versioning
                mappings.Add("woff", "application/x-font-woff");                                                   // Web Open Font Format
                mappings.Add("wspolicy", "application/wspolicy+xml");                                              // Web Services Policy
                mappings.Add("webp", "image/webp");                                                                // WebP Image
                mappings.Add("wtb", "application/vnd.webturbo");                                                   // WebTurbo
                mappings.Add("wgt", "application/widget");                                                         // Widget Packaging and XML Configuration
                mappings.Add("hlp", "application/winhlp");                                                         // WinHelp
                mappings.Add("wml", "text/vnd.wap.wml");                                                           // Wireless Markup Language (WML)
                mappings.Add("wmls", "text/vnd.wap.wmlscript");                                                    // Wireless Markup Language Script (WMLScript)
                mappings.Add("wmlsc", "application/vnd.wap.wmlscriptc");                                           // WMLScript
                mappings.Add("wpd", "application/vnd.wordperfect");                                                // Wordperfect
                mappings.Add("stf", "application/vnd.wt.stf");                                                     // Worldtalk
                mappings.Add("wsdl", "application/wsdl+xml");                                                      // WSDL - Web Services Description Language
                mappings.Add("xbm", "image/x-xbitmap");                                                            // X BitMap
                mappings.Add("xpm", "image/x-xpixmap");                                                            // X PixMap
                mappings.Add("xwd", "image/x-xwindowdump");                                                        // X Window Dump
                mappings.Add("der", "application/x-x509-ca-cert");                                                 // X.509 Certificate
                mappings.Add("fig", "application/x-xfig");                                                         // Xfig
                mappings.Add("xhtml", "application/xhtml+xml");                                                    // XHTML - The Extensible HyperText Markup Language
                mappings.Add("xml", "application/xml");                                                            // XML - Extensible Markup Language
                mappings.Add("xdf", "application/xcap-diff+xml");                                                  // XML Configuration Access Protocol - XCAP Diff
                mappings.Add("xenc", "application/xenc+xml");                                                      // XML Encryption Syntax and Processing
                mappings.Add("xer", "application/patch-ops-error+xml");                                            // XML Patch Framework
                mappings.Add("rl", "application/resource-lists+xml");                                              // XML Resource Lists
                mappings.Add("rs", "application/rls-services+xml");                                                // XML Resource Lists
                mappings.Add("rld", "application/resource-lists-diff+xml");                                        // XML Resource Lists Diff
                mappings.Add("xslt", "application/xslt+xml");                                                      // XML Transformations
                mappings.Add("xop", "application/xop+xml");                                                        // XML-Binary Optimized Packaging
                mappings.Add("xpi", "application/x-xpinstall");                                                    // XPInstall - Mozilla
                mappings.Add("xspf", "application/xspf+xml");                                                      // XSPF - XML Shareable Playlist Format
                mappings.Add("xul", "application/vnd.mozilla.xul+xml");                                            // XUL - XML User Interface Language
                mappings.Add("xyz", "chemical/x-xyz");                                                             // XYZ File Format
                mappings.Add("yang", "application/yang");                                                          // YANG Data Modeling Language
                mappings.Add("yin", "application/yin+xml");                                                        // YIN (YANG - XML)
                mappings.Add("zir", "application/vnd.zul");                                                        // Z.U.L. Geometry
                mappings.Add("zip", "application/zip");                                                            // Zip Archive
                mappings.Add("zmm", "application/vnd.handheld-entertainment+xml");                                 // ZVUE Media Manager
                mappings.Add("zaz", "application/vnd.zzazz.deck+xml");                                             // Zzazz Deck
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion
    }
}

////Kenamea App	application/vnd.kenameaapp	.htke	IANA: Kenamea App
////Kidspiration	application/vnd.kidspiration	.kia	IANA: Kidspiration
////Kinar Applications	application/vnd.kinar	.kne	IANA: Kina Applications
////Kodak Storyshare	application/vnd.kodak-descriptor	.sse	IANA: Kodak Storyshare
////Laser App Enterprise	application/vnd.las.las+xml	.lasxml	IANA: Laser App Enterprise
////LaTeX	application/x-latex	.latex	Wikipedia: LaTeX
////Life Balance - Desktop Edition	application/vnd.llamagraphics.life-balance.desktop	.lbd	IANA: Life Balance
////Life Balance - Exchange Format	application/vnd.llamagraphics.life-balance.exchange+xml	.lbe	IANA: Life Balance
////Lightspeed Audio Lab	application/vnd.jam	.jam	IANA: Lightspeed Audio Lab
////Lucent Voice	audio/vnd.lucent.voice	.lvp	IANA: Lucent Voice
////M3U (Multimedia Playlist)	audio/x-mpegurl	.m3u	Wikipedia: M3U
////M4v	video/x-m4v	.m4v	Wikipedia: M4v
////Macintosh BinHex 4.0	application/mac-binhex40	.hqx	MacMIME
////MacPorts Port System	application/vnd.macports.portpkg	.portpkg	IANA: MacPorts Port System
////MapGuide DBXML	application/vnd.osgeo.mapguide.package	.mgp	IANA: MapGuide DBXML
////MARC Formats	application/marc	.mrc	RFC 2220
////MARC21 XML Schema	application/marcxml+xml	.mrcx	RFC 6207
////Material Exchange Format	application/mxf	.mxf	RFC 4539
////Mathematica Notebook Player	application/vnd.wolfram.player	.nbp	IANA: Mathematica Notebook Player
////Mathematica Notebooks	application/mathematica	.ma	IANA - Mathematica
////Mathematical Markup Language	application/mathml+xml	.mathml	W3C Math Home
////Mbox database files	application/mbox	.mbox	RFC 4155
////MedCalc	application/vnd.medcalcdata	.mc1	IANA: MedCalc
////Media Server Control Markup Language	application/mediaservercontrol+xml	.mscml	RFC 5022
////MediaRemote	application/vnd.mediastation.cdkey	.cdkey	IANA: MediaRemote
////Medical Waveform Encoding Format	application/vnd.mfer	.mwf	IANA: Medical Waveform Encoding Format
////Melody Format for Mobile Platform	application/vnd.mfmp	.mfm	IANA: Melody Format for Mobile Platform
////Mesh Data Type	model/mesh	.msh	RFC 2077
////Metadata Authority Description Schema	application/mads+xml	.mads	RFC 6207
////Metadata Encoding and Transmission Standard	application/mets+xml	.mets	RFC 6207
////Metadata Object Description Schema	application/mods+xml	.mods	RFC 6207
////Metalink	application/metalink4+xml	.meta4	Wikipedia: Metalink
////Micro CADAM Helix D&D	application/vnd.mcd	.mcd	IANA: Micro CADAM Helix D&D
////Micrografx	application/vnd.micrografx.flo	.flo	IANA: Micrografx
////Micrografx iGrafx Professional	application/vnd.micrografx.igx	.igx	IANA: Micrografx
////MICROSEC e-Szign¢	application/vnd.eszigno3+xml	.es3	IANA: MICROSEC e-Szign¢
////MIDI - Musical Instrument Digital Interface	audio/midi	.mid	Wikipedia: MIDI
////MiniPay	application/vnd.ibm.minipay	.mpy	IANA: MiniPay
////MO:DCA-P	application/vnd.ibm.modcap	.afp	IANA: MO:DCA-P
////Mobile Information Device Profile	application/vnd.jcp.javame.midlet-rms	.rms	IANA: Mobile Information Device Profile
////MobileTV	application/vnd.tmobile-livetv	.tmo	IANA: MobileTV
////Mobipocket	application/x-mobipocket-ebook	.prc	Wikipedia: Mobipocket
////Mobius Management Systems - Basket file	application/vnd.mobius.mbk	.mbk	IANA: Mobius Management Systems
////Mobius Management Systems - Distribution Database	application/vnd.mobius.dis	.dis	IANA: Mobius Management Systems
////Mobius Management Systems - Policy Definition Language File	application/vnd.mobius.plc	.plc	IANA: Mobius Management Systems
////Mobius Management Systems - Query File	application/vnd.mobius.mqy	.mqy	IANA: Mobius Management Systems
////Mobius Management Systems - Script Language	application/vnd.mobius.msl	.msl	IANA: Mobius Management Systems
////Mobius Management Systems - Topic Index File	application/vnd.mobius.txf	.txf	IANA: Mobius Management Systems
////Mobius Management Systems - UniversalArchive	application/vnd.mobius.daf	.daf	IANA: Mobius Management Systems
////mod_fly / fly.cgi	text/vnd.fly	.fly	IANA: Fly
////Mophun Certificate	application/vnd.mophun.certificate	.mpc	IANA: Mophun Certificate
////Mophun VM	application/vnd.mophun.application	.mpn	IANA: Mophun VM
////Multimedia Playlist Unicode	application/vnd.apple.mpegurl	.m3u8	Wikipedia: M3U
////MUsical Score Interpreted Code Invented for the ASCII designation of Notation	application/vnd.musician	.mus	IANA: MUSICIAN
////Muvee Automatic Video Editing	application/vnd.muvee.style	.msty	IANA: Muvee
////MXML	application/xv+xml	.mxml	Wikipedia: MXML
////N-Gage Game Data	application/vnd.nokia.n-gage.data	.ngdat	IANA: N-Gage Game Data
////N-Gage Game Installer	application/vnd.nokia.n-gage.symbian.install	.n-gage	IANA: N-Gage Game Installer
////Navigation Control file for XML (for ePub)	application/x-dtbncx+xml	.ncx	Wikipedia: EPUB
////Network Common Data Form (NetCDF)	application/x-netcdf	.nc	Wikipedia: NetCDF
////neuroLanguage	application/vnd.neurolanguage.nlu	.nlu	IANA: neuroLanguage
////New Moon Liftoff/DNA	application/vnd.dna	.dna	IANA: New Moon Liftoff/DNA
////NobleNet Directory	application/vnd.noblenet-directory	.nnd	IANA: NobleNet Directory
////NobleNet Sealer	application/vnd.noblenet-sealer	.nns	IANA: NobleNet Sealer
////NobleNet Web	application/vnd.noblenet-web	.nnw	IANA: NobleNet Web
////Nokia Radio Application - Preset	application/vnd.nokia.radio-preset	.rpst	IANA: Nokia Radio Application
////Nokia Radio Application - Preset	application/vnd.nokia.radio-presets	.rpss	IANA: Nokia Radio Application
////Notation3	text/n3	.n3	Wikipedia: Notation3
////Novadigm's RADIA and EDM products	application/vnd.novadigm.edm	.edm	IANA: Novadigm's RADIA and EDM products
////Novadigm's RADIA and EDM products	application/vnd.novadigm.edx	.edx	IANA: Novadigm's RADIA and EDM products
////Novadigm's RADIA and EDM products	application/vnd.novadigm.ext	.ext	IANA: Novadigm's RADIA and EDM products
////NpGraphIt	application/vnd.flographit	.gph	IANA: FloGraphIt
////Nuera ECELP 4800	audio/vnd.nuera.ecelp4800	.ecelp4800	IANA: ECELP 4800
////Nuera ECELP 7470	audio/vnd.nuera.ecelp7470	.ecelp7470	IANA: ECELP 7470
////Nuera ECELP 9600	audio/vnd.nuera.ecelp9600	.ecelp9600	IANA: ECELP 9600
////PawaaFILE	application/vnd.pawaafile	.paw	IANA: PawaaFILE
////PCL 6 Enhanced (Formely PCL XL)	application/vnd.hp-pclxl	.pclxl	IANA: HP PCL XL
////Pcsel eFIF File	application/vnd.picsel	.efif	IANA: Picsel eFIF File
////PCX Image	image/x-pcx	.pcx	Wikipedia: PCX
////Photoshop Document	image/vnd.adobe.photoshop	.psd	Wikipedia: Photoshop Document
////PICSRules	application/pics-rules	.prf	W3C PICSRules
////PICT Image	image/x-pict	.pic	Wikipedia: PICT
////pIRCh	application/x-chat	.chat	Wikipedia: pIRCh
////PKCS #10 - Certification Request Standard	application/pkcs10	.p10	RFC 2986
////PKCS #12 - Personal Information Exchange Syntax Standard	application/x-pkcs12	.p12	RFC 2986
////PKCS #7 - Cryptographic Message Syntax Standard	application/pkcs7-mime	.p7m	RFC 2315
////PKCS #7 - Cryptographic Message Syntax Standard	application/pkcs7-signature	.p7s	RFC 2315
////PKCS #7 - Cryptographic Message Syntax Standard (Certificate Request Response)	application/x-pkcs7-certreqresp	.p7r	RFC 2986
////PKCS #7 - Cryptographic Message Syntax Standard (Certificates)	application/x-pkcs7-certificates	.p7b	RFC 2986
////PKCS #8 - Private-Key Information Syntax Standard	application/pkcs8	.p8	RFC 5208
////PocketLearn Viewers	application/vnd.pocketlearn	.plf	IANA: PocketLearn Viewers
////Pretty Good Privacy	application/pgp-encrypted		RFC 2015
////Pretty Good Privacy - Signature	application/pgp-signature	.pgp	RFC 2015
////Preview Systems ZipLock/VBox	application/vnd.previewsystems.box	.box	IANA: Preview Systems ZipLock/Vbox
////Princeton Video Image	application/vnd.pvi.ptid1	.ptid	IANA: Princeton Video Image
////Pronunciation Lexicon Specification	application/pls+xml	.pls	RFC 4267
////Proprietary P&G Standard Reporting System	application/vnd.pg.format	.str	IANA: Proprietary P&G Standard Reporting System
////Proprietary P&G Standard Reporting System	application/vnd.pg.osasli	.ei6	IANA: Proprietary P&G Standard Reporting System
////PRS Lines Tag	text/prs.lines.tag	.dsc	IANA: PRS Lines Tag
////PSF Fonts	application/x-font-linux-psf	.psf	PSF Fonts
////PubliShare Objects	application/vnd.publishare-delta-tree	.qps	IANA: PubliShare Objects
////Qualcomm's Plaza Mobile Internet	application/vnd.pmi.widget	.wg	IANA: Qualcomm's Plaza Mobile Internet
////QuarkXpress	application/vnd.quark.quarkxpress	.qxd	IANA: QuarkXPress
////QUASS Stream Player	application/vnd.epson.esf	.esf	IANA: QUASS Stream Player
////QUASS Stream Player	application/vnd.epson.msf	.msf	IANA: QUASS Stream Player
////QUASS Stream Player	application/vnd.epson.ssf	.ssf	IANA: QUASS Stream Player
////QuickAnime Player	application/vnd.epson.quickanime	.qam	IANA: QuickAnime Player
////Recordare Applications	application/vnd.recordare.musicxml	.mxl	IANA: Recordare Apps
////Recordare Applications	application/vnd.recordare.musicxml+xml	.musicxml	IANA: Recordare Apps
////Relax NG Compact Syntax	application/relax-ng-compact-syntax	.rnc	Relax NG
////RemoteDocs R-Viewer	application/vnd.data-vision.rdz	.rdz	IANA: Data-Vision
////Resource Description Framework	application/rdf+xml	.rdf	RFC 3870
////RetroPlatform Player	application/vnd.cloanto.rp9	.rp9	IANA: RetroPlatform Player
////RhymBox	application/vnd.jisp	.jisp	IANA: RhymBox
////ROUTE 66 Location Based Services	application/vnd.route66.link66+xml	.link66	IANA: ROUTE 66
////RSS - Really Simple Syndication	application/rss+xml	.rss, .xml	Wikipedia: RSS
////S Hexdump Format	application/shf+xml	.shf	RFC 4194
////SailingTracker	application/vnd.sailingtracker.track	.st	IANA: SailingTracker
////Scalable Vector Graphics (SVG)	image/svg+xml	.svg	Wikipedia: SVG
////ScheduleUs	application/vnd.sus-calendar	.sus	IANA: ScheduleUs
////Search/Retrieve via URL Response Format	application/sru+xml	.sru	RFC 6207
////Secure Electronic Transaction - Payment	application/set-payment-initiation	.setpay	IANA: SET Payment
////Secure Electronic Transaction - Registration	application/set-registration-initiation	.setreg	IANA: SET Registration
////Secured eMail	application/vnd.sema	.sema	IANA: Secured eMail
////Secured eMail	application/vnd.semd	.semd	IANA: Secured eMail
////Secured eMail	application/vnd.semf	.semf	IANA: Secured eMail
////SeeMail	application/vnd.seemail	.see	IANA: SeeMail
////Server Normal Format	application/x-font-snf	.snf	Wikipedia: Server Normal Format
////Server-Based Certificate Validation Protocol - Validation Policies - Request	application/scvp-vp-request	.spq	RFC 5055
////Server-Based Certificate Validation Protocol - Validation Policies - Response	application/scvp-vp-response	.spp	RFC 5055
////Server-Based Certificate Validation Protocol - Validation Request	application/scvp-cv-request	.scq	RFC 5055
////Server-Based Certificate Validation Protocol - Validation Response	application/scvp-cv-response	.scs	RFC 5055
////Session Description Protocol	application/sdp	.sdp	RFC 2327
////Setext	text/x-setext	.etx	Wikipedia: Setext
////SGI Movie	video/x-sgi-movie	.movie	SGI Facts
////Shana Informed Filler	application/vnd.shana.informed.formdata	.ifm	IANA: Shana Informed Filler
////Shana Informed Filler	application/vnd.shana.informed.formtemplate	.itp	IANA: Shana Informed Filler
////Shana Informed Filler	application/vnd.shana.informed.interchange	.iif	IANA: Shana Informed Filler
////Shana Informed Filler	application/vnd.shana.informed.package	.ipk	IANA: Shana Informed Filler
////Sharing Transaction Fraud Data	application/thraud+xml	.tfi	RFC 5941
////Shell Archive	application/x-shar	.shar	Wikipedia: Shell Archie
////Silicon Graphics RGB Bitmap	image/x-rgb	.rgb	RGB Image Format
////SimpleAnimeLite Player	application/vnd.epson.salt	.slt	IANA: SimpleAnimeLite Player
////Simply Accounting	application/vnd.accpac.simply.aso	.aso	IANA: Simply Accounting
////Simply Accounting - Data Import	application/vnd.accpac.simply.imp	.imp	IANA: Simply Accounting
////SimTech MindMapper	application/vnd.simtech-mindmapper	.twd	IANA: SimTech MindMapper
////Sixth Floor Media - CommonSpace	application/vnd.commonspace	.csp	IANA: CommonSpace
////SMAF Audio	application/vnd.yamaha.smaf-audio	.saf	IANA: SMAF Audio
////SMAF File	application/vnd.smaf	.mmf	IANA: SMAF File
////SMAF Phrase	application/vnd.yamaha.smaf-phrase	.spf	IANA: SMAF Phrase
////SMART Technologies Apps	application/vnd.smart.teacher	.teacher	IANA: SMART Technologies Apps
////SourceView Document	application/vnd.svd	.svd	IANA: SourceView Document
////SPARQL - Query	application/sparql-query	.rq	W3C SPARQL
////SPARQL - Results	application/sparql-results+xml	.srx	W3C SPARQL
////Speech Recognition Grammar Specification	application/srgs	.gram	W3C Speech Grammar
////Speech Recognition Grammar Specification - XML	application/srgs+xml	.grxml	W3C Speech Grammar
////Speech Synthesis Markup Language	application/ssml+xml	.ssml	W3C Speech Synthesis
////SSEYO Koan Play File	application/vnd.koan	.skp	IANA: SSEYO Koan Play File
////StepMania	application/vnd.stepmania.stepchart	.sm	IANA: StepMania
////Stuffit Archive	application/x-stuffit	.sit	Wikipedia: Stuffit
////Stuffit Archive	application/x-stuffitx	.sitx	Wikipedia: Stuffit
////SudokuMagic	application/vnd.solent.sdkm+xml	.sdkm	IANA: SudokuMagic
////Sugar Linux Application Bundle	application/vnd.olpc-sugar	.xo	IANA: Sugar Linux App Bundle
////Sun Audio - Au file format	audio/basic	.au	Wikipedia: Sun audio
////SundaHus WQ	application/vnd.wqd	.wqd	IANA: SundaHus WQ
////Synchronized Multimedia Integration Language	application/smil+xml	.smi	RFC 4536
////SyncML	application/vnd.syncml+xml	.xsm	IANA: SyncML
////SyncML - Device Management	application/vnd.syncml.dm+wbxml	.bdm	IANA: SyncML
////SyncML - Device Management	application/vnd.syncml.dm+xml	.xdm	IANA: SyncML
////System V Release 4 CPIO Archive	application/x-sv4cpio	.sv4cpio	Wikipedia: pax
////System V Release 4 CPIO Checksum Data	application/x-sv4crc	.sv4crc	Wikipedia: pax
////Systems Biology Markup Language	application/sbml+xml	.sbml	RFC 3823
////Tab Seperated Values	text/tab-separated-values	.tsv	Wikipedia: TSV
////Tagged Image File Format	image/tiff	.tiff	Wikipedia: TIFF
////Tao Intent	application/vnd.tao.intent-module-archive	.tao	IANA: Tao Intent
////Tar File (Tape Archive)	application/x-tar	.tar	Wikipedia: Tar
////Tcl Script	application/x-tcl	.tcl	Wikipedia: Tcl
////TIBCO Spotfire	application/vnd.spotfire.dxp	.dxp	IANA: TIBCO Spotfire
////TIBCO Spotfire	application/vnd.spotfire.sfs	.sfs	IANA: TIBCO Spotfire
////Time Stamped Data Envelope	application/timestamped-data	.tsd	RFC 5955
////TRI Systems Config	application/vnd.trid.tpt	.tpt	IANA: TRI Systems
////Triscape Map Explorer	application/vnd.triscape.mxs	.mxs	IANA: Triscape Map Explorer
////troff	text/troff	.t	Wikipedia: troff
////True BASIC	application/vnd.trueapp	.tra	IANA: True BASIC
////TrueType Font	application/x-font-ttf	.ttf	Wikipedia: TrueType
////Turtle (Terse RDF Triple Language)	text/turtle	.ttl	Wikipedia: Turtle
////UMAJIN	application/vnd.umajin	.umj	IANA: UMAJIN
////Unique Object Markup Language	application/vnd.uoml+xml	.uoml	IANA: UOML
////Unity 3d	application/vnd.unity	.unityweb	IANA: Unity 3d
////Universal Forms Description Language	application/vnd.ufdl	.ufd	IANA: Universal Forms Description Language
////URI Resolution Services	text/uri-list	.uri	RFC 2483
////User Interface Quartz - Theme (Symbian)	application/vnd.uiq.theme	.utz	IANA: User Interface Quartz
////Ustar (Uniform Standard Tape Archive)	application/x-ustar	.ustar	Wikipedia: Ustar
////UUEncode	text/x-uuencode	.uu	Wikipedia: UUEncode
////vCalendar	text/x-vcalendar	.vcs	Wikipedia: vCalendar
////vCard	text/x-vcard	.vcf	Wikipedia: vCard
////Viewport+	application/vnd.vsf	.vsf	IANA: Viewport+
////Virtual Reality Modeling Language	model/vrml	.wrl	Wikipedia: VRML
////VirtualCatalog	application/vnd.vcx	.vcx	IANA: VirtualCatalog
////Virtue MTS	model/vnd.mts	.mts	IANA: MTS
////Virtue VTU	model/vnd.vtu	.vtu	IANA: VTU
////Visionary	application/vnd.visionary	.vis	IANA: Visionary
////Vivo	video/vnd.vivo	.viv	IANA: Vivo
////Voice Browser Call Control	application/ccxml+xml,	.ccxml	Voice Browser Call Control: CCXML Version 1.0
////VoiceXML	application/voicexml+xml	.vxml	RFC 4267
