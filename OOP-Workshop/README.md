This is a private repository between:
Tobias,
Mikkel,
Vedran

Students at SDU conducting a workshop in OOP.

Mermaid UML diagram live editor link:
https://www.mermaidchart.com/app/projects/1d833c81-fdfb-403a-bfaa-77a4ad8a1839/diagrams/403decbf-f720-49f4-a532-160fbb4d25a8/share/invite/eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudElEIjoiNDAzZGVjYmYtZjcyMC00OWY0LWE1MzItMTYwZmJiNGQyNWE4IiwiYWNjZXNzIjoiRWRpdCIsImlhdCI6MTc2MzM4NDAyM30.f2rRiABVw4NS0CPf63n8jMo_lXRVngxTdh1z0_chm18


New Mermaid Test:
```mermaid
  classDiagram
direction TB
    class BaseUser {
	    + int x
	    + void xx()
    }

    class Borrower {
        
        + RateItem()
    }

    class Employee {
    }

    class Admin {
    }

    class BaseMedia {
	    - string title
	    + string GetTitle()
    }

    class E-Books {
	    + title string
	    + author string
	    + pages int
	    + publishYear int
	    + ISBN string
	    + language string
        + Download()
        + View()
    }

    class Movies {
	    + title string
	    + director string
	    + genres string
	    + releaseYear int
	    + language string
	    + duration int
        + Download()
        + Watch()
    }

    class Songs {
	    + title string
	    + composer string
	    + singer string
	    + genre string
	    + fileType string
	    + langauge string
	    + duration int
        + Download()
        + PlaySong()
    }

    class Video-games {
	    + title string
	    + publisher string
	    + genre string
	    + releaseYear int
	    + supportedPlatforms string[]
        + isCompleted bool
        + Download()
        + PlayGame()
    }

    class Apps {
	    + title string
	    + publisher string
	    + version int
	    + language string
	    + supportedPlatforms string[]
        + Download()
        + Execute()
    }

    class Podcasts {
        + title string
        + hosts string
        + guests string
        + episodeNumber int
        + releaseYear int
        + language string
        + episodeNumberIsComplete int
        + Download()
        + PlayPodcast()
    }

    class Images {
	    + title string
        + resolution string
        + fileFormat string
        + fileSize long
        + dateTaken string
        + Download()
        + Display()
    }

    BaseUser <|-- Borrower
    BaseUser <|-- Employee
    BaseUser <|-- Admin
    BaseMedia <|-- E-Books
    BaseMedia <|-- Movies
    BaseMedia <|-- Songs
    BaseMedia <|-- Songs
    BaseMedia <|-- Video-games
    BaseMedia <|-- Apps
    BaseMedia <|-- Podcasts
    BaseMedia <|-- Images
```

```html
<html xmlns:v="urn:schemas-microsoft-com:vml"
xmlns:o="urn:schemas-microsoft-com:office:office"
xmlns:w="urn:schemas-microsoft-com:office:word"
xmlns:dt="uuid:C2F41010-65B3-11d1-A29F-00AA00C14882"
xmlns:m="http://schemas.microsoft.com/office/2004/12/omml"
xmlns="http://www.w3.org/TR/REC-html40">

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1252">
<meta name=ProgId content=Word.Document>
<meta name=Generator content="Microsoft Word 15">
<meta name=Originator content="Microsoft Word 15">
<link rel=File-List href="Workshop%20-%20NounVerb-filer/filelist.xml">
<!--[if gte mso 9]><xml>
 <o:DocumentProperties>
  <o:Author>Mikkel Ryborg Blom</o:Author>
  <o:LastAuthor>Mikkel Ryborg Blom</o:LastAuthor>
  <o:Revision>2</o:Revision>
  <o:TotalTime>7</o:TotalTime>
  <o:Created>2025-11-17T13:51:00Z</o:Created>
  <o:LastSaved>2025-11-17T13:51:00Z</o:LastSaved>
  <o:Pages>2</o:Pages>
  <o:Words>346</o:Words>
  <o:Characters>2115</o:Characters>
  <o:Bytes>Dokument</o:Bytes>
  <o:Lines>17</o:Lines>
  <o:Paragraphs>4</o:Paragraphs>
  <o:CharactersWithSpaces>2457</o:CharactersWithSpaces>
  <o:Version>16.00</o:Version>
 </o:DocumentProperties>
 <o:CustomDocumentProperties>
  <o:ContentTypeId dt:dt="string">0x010100057F7CBD2190AE4E8405F934D387C00E</o:ContentTypeId>
 </o:CustomDocumentProperties>
 <o:OfficeDocumentSettings>
  <o:AllowPNG/>
 </o:OfficeDocumentSettings>
</xml><![endif]-->
<link rel=dataStoreItem href="Workshop%20-%20NounVerb-filer/item0001.xml"
target="Workshop%20-%20NounVerb-filer/props002.xml">
<link rel=dataStoreItem href="Workshop%20-%20NounVerb-filer/item0003.xml"
target="Workshop%20-%20NounVerb-filer/props004.xml">
<link rel=dataStoreItem href="Workshop%20-%20NounVerb-filer/item0005.xml"
target="Workshop%20-%20NounVerb-filer/props006.xml">
<link rel=themeData href="Workshop%20-%20NounVerb-filer/themedata.thmx">
<link rel=colorSchemeMapping
href="Workshop%20-%20NounVerb-filer/colorschememapping.xml">
<!--[if gte mso 9]><xml>
 <w:WordDocument>
  <w:SpellingState>Clean</w:SpellingState>
  <w:GrammarState>Clean</w:GrammarState>
  <w:TrackMoves>false</w:TrackMoves>
  <w:TrackFormatting/>
  <w:HyphenationZone>21</w:HyphenationZone>
  <w:PunctuationKerning/>
  <w:ValidateAgainstSchemas/>
  <w:SaveIfXMLInvalid>false</w:SaveIfXMLInvalid>
  <w:IgnoreMixedContent>false</w:IgnoreMixedContent>
  <w:AlwaysShowPlaceholderText>false</w:AlwaysShowPlaceholderText>
  <w:DoNotPromoteQF/>
  <w:LidThemeOther>DA</w:LidThemeOther>
  <w:LidThemeAsian>X-NONE</w:LidThemeAsian>
  <w:LidThemeComplexScript>NE</w:LidThemeComplexScript>
  <w:Compatibility>
   <w:BreakWrappedTables/>
   <w:SnapToGridInCell/>
   <w:WrapTextWithPunct/>
   <w:UseAsianBreakRules/>
   <w:DontGrowAutofit/>
   <w:SplitPgBreakAndParaMark/>
   <w:EnableOpenTypeKerning/>
   <w:DontFlipMirrorIndents/>
   <w:OverrideTableStyleHps/>
  </w:Compatibility>
  <m:mathPr>
   <m:mathFont m:val="Cambria Math"/>
   <m:brkBin m:val="before"/>
   <m:brkBinSub m:val="&#45;-"/>
   <m:smallFrac m:val="off"/>
   <m:dispDef/>
   <m:lMargin m:val="0"/>
   <m:rMargin m:val="0"/>
   <m:defJc m:val="centerGroup"/>
   <m:wrapIndent m:val="1440"/>
   <m:intLim m:val="subSup"/>
   <m:naryLim m:val="undOvr"/>
  </m:mathPr></w:WordDocument>
</xml><![endif]--><!--[if gte mso 9]><xml>
 <w:LatentStyles DefLockedState="false" DefUnhideWhenUsed="false"
  DefSemiHidden="false" DefQFormat="false" DefPriority="99"
  LatentStyleCount="376">
  <w:LsdException Locked="false" Priority="0" QFormat="true" Name="Normal"/>
  <w:LsdException Locked="false" Priority="9" QFormat="true" Name="heading 1"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 2"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 3"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 4"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 5"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 6"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 7"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 8"/>
  <w:LsdException Locked="false" Priority="9" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="heading 9"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index 9"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 1"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 2"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 3"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 4"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 5"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 6"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 7"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 8"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" Name="toc 9"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footnote text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="header"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footer"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="index heading"/>
  <w:LsdException Locked="false" Priority="35" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="caption"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="table of figures"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="envelope address"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="envelope return"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="footnote reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="line number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="page number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="endnote reference"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="endnote text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="table of authorities"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="macro"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="toa heading"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Bullet 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Number 5"/>
  <w:LsdException Locked="false" Priority="10" QFormat="true" Name="Title"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Closing"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Signature"/>
  <w:LsdException Locked="false" Priority="1" SemiHidden="true"
   UnhideWhenUsed="true" Name="Default Paragraph Font"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="List Continue 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Message Header"/>
  <w:LsdException Locked="false" Priority="11" QFormat="true" Name="Subtitle"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Salutation"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Date"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text First Indent"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text First Indent 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Note Heading"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Body Text Indent 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Block Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Hyperlink"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="FollowedHyperlink"/>
  <w:LsdException Locked="false" Priority="22" QFormat="true" Name="Strong"/>
  <w:LsdException Locked="false" Priority="20" QFormat="true" Name="Emphasis"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Document Map"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Plain Text"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="E-mail Signature"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Top of Form"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Bottom of Form"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal (Web)"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Acronym"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Address"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Cite"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Code"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Definition"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Keyboard"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Preformatted"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Sample"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Typewriter"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="HTML Variable"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Normal Table"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="annotation subject"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="No List"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Outline List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Simple 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Classic 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Colorful 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Columns 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Grid 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 4"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 5"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 7"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table List 8"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table 3D effects 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Contemporary"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Elegant"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Professional"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Subtle 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Subtle 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 1"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 2"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Web 3"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Balloon Text"/>
  <w:LsdException Locked="false" Priority="39" Name="Table Grid"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Table Theme"/>
  <w:LsdException Locked="false" SemiHidden="true" Name="Placeholder Text"/>
  <w:LsdException Locked="false" Priority="1" QFormat="true" Name="No Spacing"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 1"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 1"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 1"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 1"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 1"/>
  <w:LsdException Locked="false" SemiHidden="true" Name="Revision"/>
  <w:LsdException Locked="false" Priority="34" QFormat="true"
   Name="List Paragraph"/>
  <w:LsdException Locked="false" Priority="29" QFormat="true" Name="Quote"/>
  <w:LsdException Locked="false" Priority="30" QFormat="true"
   Name="Intense Quote"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 1"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 1"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 1"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 1"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 1"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 2"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 2"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 2"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 2"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 2"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 2"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 2"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 2"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 3"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 3"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 3"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 3"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 3"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 3"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 3"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 3"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 4"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 4"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 4"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 4"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 4"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 4"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 4"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 4"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 5"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 5"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 5"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 5"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 5"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 5"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 5"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 5"/>
  <w:LsdException Locked="false" Priority="60" Name="Light Shading Accent 6"/>
  <w:LsdException Locked="false" Priority="61" Name="Light List Accent 6"/>
  <w:LsdException Locked="false" Priority="62" Name="Light Grid Accent 6"/>
  <w:LsdException Locked="false" Priority="63" Name="Medium Shading 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="64" Name="Medium Shading 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="65" Name="Medium List 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="66" Name="Medium List 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="67" Name="Medium Grid 1 Accent 6"/>
  <w:LsdException Locked="false" Priority="68" Name="Medium Grid 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="69" Name="Medium Grid 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="70" Name="Dark List Accent 6"/>
  <w:LsdException Locked="false" Priority="71" Name="Colorful Shading Accent 6"/>
  <w:LsdException Locked="false" Priority="72" Name="Colorful List Accent 6"/>
  <w:LsdException Locked="false" Priority="73" Name="Colorful Grid Accent 6"/>
  <w:LsdException Locked="false" Priority="19" QFormat="true"
   Name="Subtle Emphasis"/>
  <w:LsdException Locked="false" Priority="21" QFormat="true"
   Name="Intense Emphasis"/>
  <w:LsdException Locked="false" Priority="31" QFormat="true"
   Name="Subtle Reference"/>
  <w:LsdException Locked="false" Priority="32" QFormat="true"
   Name="Intense Reference"/>
  <w:LsdException Locked="false" Priority="33" QFormat="true" Name="Book Title"/>
  <w:LsdException Locked="false" Priority="37" SemiHidden="true"
   UnhideWhenUsed="true" Name="Bibliography"/>
  <w:LsdException Locked="false" Priority="39" SemiHidden="true"
   UnhideWhenUsed="true" QFormat="true" Name="TOC Heading"/>
  <w:LsdException Locked="false" Priority="41" Name="Plain Table 1"/>
  <w:LsdException Locked="false" Priority="42" Name="Plain Table 2"/>
  <w:LsdException Locked="false" Priority="43" Name="Plain Table 3"/>
  <w:LsdException Locked="false" Priority="44" Name="Plain Table 4"/>
  <w:LsdException Locked="false" Priority="45" Name="Plain Table 5"/>
  <w:LsdException Locked="false" Priority="40" Name="Grid Table Light"/>
  <w:LsdException Locked="false" Priority="46" Name="Grid Table 1 Light"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark"/>
  <w:LsdException Locked="false" Priority="51" Name="Grid Table 6 Colorful"/>
  <w:LsdException Locked="false" Priority="52" Name="Grid Table 7 Colorful"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 1"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 1"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 1"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 2"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 2"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 2"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 3"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 3"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 3"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 4"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 4"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 4"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 5"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 5"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 5"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="46"
   Name="Grid Table 1 Light Accent 6"/>
  <w:LsdException Locked="false" Priority="47" Name="Grid Table 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="48" Name="Grid Table 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="49" Name="Grid Table 4 Accent 6"/>
  <w:LsdException Locked="false" Priority="50" Name="Grid Table 5 Dark Accent 6"/>
  <w:LsdException Locked="false" Priority="51"
   Name="Grid Table 6 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="52"
   Name="Grid Table 7 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="46" Name="List Table 1 Light"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark"/>
  <w:LsdException Locked="false" Priority="51" Name="List Table 6 Colorful"/>
  <w:LsdException Locked="false" Priority="52" Name="List Table 7 Colorful"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 1"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 1"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 1"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 1"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 1"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 1"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 2"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 2"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 2"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 2"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 2"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 2"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 3"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 3"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 3"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 3"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 3"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 3"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 4"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 4"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 4"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 4"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 4"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 4"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 5"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 5"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 5"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 5"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 5"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 5"/>
  <w:LsdException Locked="false" Priority="46"
   Name="List Table 1 Light Accent 6"/>
  <w:LsdException Locked="false" Priority="47" Name="List Table 2 Accent 6"/>
  <w:LsdException Locked="false" Priority="48" Name="List Table 3 Accent 6"/>
  <w:LsdException Locked="false" Priority="49" Name="List Table 4 Accent 6"/>
  <w:LsdException Locked="false" Priority="50" Name="List Table 5 Dark Accent 6"/>
  <w:LsdException Locked="false" Priority="51"
   Name="List Table 6 Colorful Accent 6"/>
  <w:LsdException Locked="false" Priority="52"
   Name="List Table 7 Colorful Accent 6"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Mention"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Smart Hyperlink"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Hashtag"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Unresolved Mention"/>
  <w:LsdException Locked="false" SemiHidden="true" UnhideWhenUsed="true"
   Name="Smart Link"/>
 </w:LatentStyles>
</xml><![endif]-->
<style>
<!--
 /* Font Definitions */
 @font-face
	{font-family:Wingdings;
	panose-1:5 0 0 0 0 0 0 0 0 0;
	mso-font-charset:2;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:0 268435456 0 0 -2147483648 0;}
@font-face
	{font-family:Mangal;
	panose-1:0 0 4 0 0 0 0 0 0 0;
	mso-font-charset:0;
	mso-generic-font-family:roman;
	mso-font-pitch:variable;
	mso-font-signature:32771 0 0 0 1 0;}
@font-face
	{font-family:"Cambria Math";
	panose-1:2 4 5 3 5 4 6 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:roman;
	mso-font-pitch:variable;
	mso-font-signature:-536869121 1107305727 33554432 0 415 0;}
@font-face
	{font-family:Aptos;
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:536871559 3 0 0 415 0;}
@font-face
	{font-family:"Aptos Display";
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:536871559 3 0 0 415 0;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-parent:"";
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:8.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
h1
	{mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 1 Tegn";
	mso-style-next:Normal;
	margin-top:18.0pt;
	margin-right:0cm;
	margin-bottom:4.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:1;
	font-size:20.0pt;
	mso-bidi-font-size:18.0pt;
	font-family:"Aptos Display",sans-serif;
	mso-ascii-font-family:"Aptos Display";
	mso-ascii-theme-font:major-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:"Aptos Display";
	mso-hansi-theme-font:major-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;}
h2
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 2 Tegn";
	mso-style-next:Normal;
	margin-top:8.0pt;
	margin-right:0cm;
	margin-bottom:4.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:2;
	font-size:16.0pt;
	mso-bidi-font-size:14.5pt;
	font-family:"Aptos Display",sans-serif;
	mso-ascii-font-family:"Aptos Display";
	mso-ascii-theme-font:major-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:"Aptos Display";
	mso-hansi-theme-font:major-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;}
h3
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 3 Tegn";
	mso-style-next:Normal;
	margin-top:8.0pt;
	margin-right:0cm;
	margin-bottom:4.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:3;
	font-size:14.0pt;
	mso-bidi-font-size:12.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;}
h4
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 4 Tegn";
	mso-style-next:Normal;
	margin-top:4.0pt;
	margin-right:0cm;
	margin-bottom:2.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:4;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;
	font-style:italic;}
h5
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 5 Tegn";
	mso-style-next:Normal;
	margin-top:4.0pt;
	margin-right:0cm;
	margin-bottom:2.0pt;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:5;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;}
h6
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 6 Tegn";
	mso-style-next:Normal;
	margin-top:2.0pt;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:6;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#595959;
	mso-themecolor:text1;
	mso-themetint:166;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-weight:normal;
	font-style:italic;}
p.MsoHeading7, li.MsoHeading7, div.MsoHeading7
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 7 Tegn";
	mso-style-next:Normal;
	margin-top:2.0pt;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:7;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#595959;
	mso-themecolor:text1;
	mso-themetint:166;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
p.MsoHeading8, li.MsoHeading8, div.MsoHeading8
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 8 Tegn";
	mso-style-next:Normal;
	margin:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:8;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#272727;
	mso-themecolor:text1;
	mso-themetint:216;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;
	font-style:italic;}
p.MsoHeading9, li.MsoHeading9, div.MsoHeading9
	{mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-qformat:yes;
	mso-style-link:"Overskrift 9 Tegn";
	mso-style-next:Normal;
	margin:0cm;
	line-height:115%;
	mso-pagination:widow-orphan lines-together;
	page-break-after:avoid;
	mso-outline-level:9;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#272727;
	mso-themecolor:text1;
	mso-themetint:216;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
p.MsoListParagraph, li.MsoListParagraph, div.MsoListParagraph
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:8.0pt;
	margin-left:36.0pt;
	mso-add-space:auto;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
p.MsoListParagraphCxSpFirst, li.MsoListParagraphCxSpFirst, div.MsoListParagraphCxSpFirst
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:36.0pt;
	mso-add-space:auto;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
p.MsoListParagraphCxSpMiddle, li.MsoListParagraphCxSpMiddle, div.MsoListParagraphCxSpMiddle
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:36.0pt;
	mso-add-space:auto;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
p.MsoListParagraphCxSpLast, li.MsoListParagraphCxSpLast, div.MsoListParagraphCxSpLast
	{mso-style-priority:34;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-type:export-only;
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:8.0pt;
	margin-left:36.0pt;
	mso-add-space:auto;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
span.MsoIntenseEmphasis
	{mso-style-priority:21;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	font-style:italic;}
span.MsoIntenseReference
	{mso-style-priority:32;
	mso-style-unhide:no;
	mso-style-qformat:yes;
	font-variant:small-caps;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	letter-spacing:.25pt;
	font-weight:bold;}
span.TitleChar1
	{mso-style-name:"Title Char1";
	mso-style-priority:10;
	mso-style-unhide:no;
	mso-ansi-font-size:28.0pt;
	mso-bidi-font-size:25.0pt;
	font-family:"Aptos Display",sans-serif;
	mso-ascii-font-family:"Aptos Display";
	mso-ascii-theme-font:major-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:"Aptos Display";
	mso-hansi-theme-font:major-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	letter-spacing:-.5pt;
	mso-font-kerning:14.0pt;}
span.SubtitleChar1
	{mso-style-name:"Subtitle Char1";
	mso-style-priority:11;
	mso-style-unhide:no;
	mso-ansi-font-size:14.0pt;
	mso-bidi-font-size:12.5pt;
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:black;
	mso-themecolor:text1;
	letter-spacing:.75pt;}
span.QuoteChar1
	{mso-style-name:"Quote Char1";
	mso-style-priority:29;
	mso-style-unhide:no;
	color:black;
	mso-themecolor:text1;
	font-style:italic;}
span.IntenseQuoteChar1
	{mso-style-name:"Intense Quote Char1";
	mso-style-priority:30;
	mso-style-unhide:no;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	font-style:italic;}
span.Overskrift1Tegn
	{mso-style-name:"Overskrift 1 Tegn";
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 1";
	mso-ansi-font-size:20.0pt;
	mso-bidi-font-size:18.0pt;
	font-family:"Aptos Display",sans-serif;
	mso-ascii-font-family:"Aptos Display";
	mso-ascii-theme-font:major-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:"Aptos Display";
	mso-hansi-theme-font:major-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;}
span.Overskrift2Tegn
	{mso-style-name:"Overskrift 2 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 2";
	mso-ansi-font-size:16.0pt;
	mso-bidi-font-size:14.5pt;
	font-family:"Aptos Display",sans-serif;
	mso-ascii-font-family:"Aptos Display";
	mso-ascii-theme-font:major-latin;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-hansi-font-family:"Aptos Display";
	mso-hansi-theme-font:major-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;}
span.Overskrift3Tegn
	{mso-style-name:"Overskrift 3 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 3";
	mso-ansi-font-size:14.0pt;
	mso-bidi-font-size:12.5pt;
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;}
span.Overskrift4Tegn
	{mso-style-name:"Overskrift 4 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 4";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;
	font-style:italic;}
span.Overskrift5Tegn
	{mso-style-name:"Overskrift 5 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 5";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#0F4761;
	mso-themecolor:accent1;
	mso-themeshade:191;}
span.Overskrift6Tegn
	{mso-style-name:"Overskrift 6 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 6";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#595959;
	mso-themecolor:text1;
	mso-themetint:166;
	font-style:italic;}
span.Overskrift7Tegn
	{mso-style-name:"Overskrift 7 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 7";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#595959;
	mso-themecolor:text1;
	mso-themetint:166;}
span.Overskrift8Tegn
	{mso-style-name:"Overskrift 8 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 8";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#272727;
	mso-themecolor:text1;
	mso-themetint:216;
	font-style:italic;}
span.Overskrift9Tegn
	{mso-style-name:"Overskrift 9 Tegn";
	mso-style-noshow:yes;
	mso-style-priority:9;
	mso-style-unhide:no;
	mso-style-locked:yes;
	mso-style-link:"Overskrift 9";
	font-family:"Times New Roman",serif;
	mso-fareast-font-family:"Times New Roman";
	mso-fareast-theme-font:major-fareast;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:major-bidi;
	color:#272727;
	mso-themecolor:text1;
	mso-themetint:216;}
span.SpellE
	{mso-style-name:"";
	mso-spl-e:yes;}
span.GramE
	{mso-style-name:"";
	mso-gram-e:yes;}
.MsoChpDefault
	{mso-style-type:export-only;
	mso-default-props:yes;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;
	mso-fareast-language:EN-US;}
.MsoPapDefault
	{mso-style-type:export-only;
	margin-bottom:8.0pt;
	line-height:115%;}
@page WordSection1
	{size:595.3pt 841.9pt;
	margin:3.0cm 2.0cm 3.0cm 2.0cm;
	mso-header-margin:35.4pt;
	mso-footer-margin:35.4pt;
	mso-paper-source:0;}
div.WordSection1
	{page:WordSection1;}
 /* List Definitions */
 @list l0
	{mso-list-id:1201865723;
	mso-list-type:hybrid;
	mso-list-template-ids:1185946714 -369298826 67502083 67502085 67502081 67502083 67502085 67502081 67502083 67502085;}
@list l0:level1
	{mso-level-start-at:0;
	mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;}
@list l0:level2
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l0:level3
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
@list l0:level4
	{mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;}
@list l0:level5
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l0:level6
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
@list l0:level7
	{mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;}
@list l0:level8
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l0:level9
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
@list l1
	{mso-list-id:1654025267;
	mso-list-type:hybrid;
	mso-list-template-ids:-418849900 -265224318 67502083 67502085 67502081 67502083 67502085 67502081 67502083 67502085;}
@list l1:level1
	{mso-level-start-at:0;
	mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;
	mso-fareast-font-family:Aptos;
	mso-fareast-theme-font:minor-latin;
	mso-bidi-font-family:Mangal;
	mso-bidi-theme-font:minor-bidi;}
@list l1:level2
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l1:level3
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
@list l1:level4
	{mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;}
@list l1:level5
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l1:level6
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
@list l1:level7
	{mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Symbol;}
@list l1:level8
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:"Courier New";}
@list l1:level9
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:none;
	mso-level-number-position:left;
	text-indent:-18.0pt;
	font-family:Wingdings;}
ol
	{margin-bottom:0cm;}
ul
	{margin-bottom:0cm;}
-->
</style>
<!--[if gte mso 10]>
<style>
 /* Style Definitions */
 table.MsoNormalTable
	{mso-style-name:"Tabel - Normal";
	mso-tstyle-rowband-size:0;
	mso-tstyle-colband-size:0;
	mso-style-noshow:yes;
	mso-style-priority:99;
	mso-style-parent:"";
	mso-padding-alt:0cm 5.4pt 0cm 5.4pt;
	mso-para-margin-top:0cm;
	mso-para-margin-right:0cm;
	mso-para-margin-bottom:8.0pt;
	mso-para-margin-left:0cm;
	line-height:115%;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	mso-bidi-font-size:10.5pt;
	font-family:"Aptos",sans-serif;
	mso-ascii-font-family:Aptos;
	mso-ascii-theme-font:minor-latin;
	mso-hansi-font-family:Aptos;
	mso-hansi-theme-font:minor-latin;
	mso-font-kerning:1.0pt;
	mso-ligatures:standardcontextual;
	mso-fareast-language:EN-US;}
</style>
<![endif]--><!--[if gte mso 9]><xml>
 <o:shapedefaults v:ext="edit" spidmax="1026"/>
</xml><![endif]--><!--[if gte mso 9]><xml>
 <o:shapelayout v:ext="edit">
  <o:idmap v:ext="edit" data="1"/>
 </o:shapelayout></xml><![endif]-->
</head>

<body lang=DA style='tab-interval:65.2pt;word-wrap:break-word'>

<div class=WordSection1>

<h1 align=center style='text-align:center'><span class=SpellE><span
style='background:red;mso-highlight:red'>Noun</span></span>/<span class=SpellE><span
style='background:yellow;mso-highlight:yellow'>Verb</span></span></h1>

<p class=MsoNormal><span lang=EN-US style='mso-ansi-language:EN-US'>S nderborg s
<span style='background:red;mso-highlight:red'>library </span>aims to launch a
digital <span style='background:red;mso-highlight:red'>platform </span>to
manage and share its diverse digital <span style='background:red;mso-highlight:
red'>media </span>collection. </span>The <span style='background:red;
mso-highlight:red'>system </span><span class=SpellE>should</span> support
multiple types of <span style='background:red;mso-highlight:red'>media</span>, <span
class=SpellE>including</span>:<o:p></o:p></p>

<ul style='margin-top:0cm' type=disc>
 <li class=MsoNormal style='mso-list:l1 level1 lfo2'><span style='mso-ansi-language:
     EN-US'><span style='mso-spacerun:yes'> </span><span class=GramE><span
     lang=EN-US style='background:red;mso-highlight:red'>E</span><span
     lang=EN-US style='font-family:"Cambria Math",serif;mso-bidi-font-family:
     "Cambria Math";background:red;mso-highlight:red'>&#8209;</span><span
     lang=EN-US style='background:red;mso-highlight:red'>books</span></span><span
     lang=EN-US style='background:red;mso-highlight:red'> </span><span
     lang=EN-US>with information about their <span style='background:red;
     mso-highlight:red'>title</span>, <span style='background:red;mso-highlight:
     red'>author</span>, <span style='background:red;mso-highlight:red'>language</span>,
     <span style='background:red;mso-highlight:red'>number</span> of <span
     style='background:red;mso-highlight:red'>pages</span>, <span
     style='background:red;mso-highlight:red'>year </span>of publication and
     ISBN. </span></span><span style='background:red;mso-highlight:red'>Users </span><span
     class=SpellE>can</span> <span style='background:yellow;mso-highlight:yellow'>view</span>,
     <span style='background:yellow;mso-highlight:yellow'>download </span>and <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>read</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span><span class=SpellE>them</span>.<o:p></o:p></li>
</ul>

<ul style='margin-top:0cm' type=disc>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span style='mso-ansi-language:
     EN-US'><span style='mso-spacerun:yes'> </span><span lang=EN-US
     style='background:red;mso-highlight:red'>Movies </span><span lang=EN-US>with
     information about their title, director, genres, release year, language
     and duration. </span></span><span style='background:red;mso-highlight:
     red'>Users </span><span class=SpellE>can</span> <span class=SpellE><span
     style='background:yellow;mso-highlight:yellow'>watch</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>and <span
     style='background:yellow;mso-highlight:yellow'>download </span><span
     class=SpellE>them</span>.<o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span style='mso-ansi-language:
     EN-US'><span style='mso-spacerun:yes'> </span><span lang=EN-US
     style='background:red;mso-highlight:red'>Songs </span><span lang=EN-US>with
     information about their <span style='background:red;mso-highlight:red'>title</span>,
     <span style='background:red;mso-highlight:red'>composer</span>, <span
     style='background:red;mso-highlight:red'>singer</span>, <span
     style='background:red;mso-highlight:red'>genre</span>, <span
     style='background:red;mso-highlight:red'>file type</span>, <span
     style='background:red;mso-highlight:red'>duration </span>and <span
     style='background:red;mso-highlight:red'>language</span>. </span></span><span
     style='background:red;mso-highlight:red'>Users </span><span class=SpellE>can</span>
     <span class=SpellE>play</span> and <span style='background:red;mso-highlight:
     red'>download </span><span class=SpellE>them</span>.<o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span style='mso-ansi-language:
     EN-US'><span style='mso-spacerun:yes'> </span><span class=GramE><span
     lang=EN-US style='background:red;mso-highlight:red'>Video</span><span
     lang=EN-US style='font-family:"Cambria Math",serif;mso-bidi-font-family:
     "Cambria Math";background:red;mso-highlight:red'>&#8209;</span><span
     lang=EN-US style='background:red;mso-highlight:red'>games</span></span><span
     lang=EN-US style='background:red;mso-highlight:red'> </span><span
     lang=EN-US>with information about their <span style='background:red;
     mso-highlight:red'>title</span>, <span style='background:red;mso-highlight:
     red'>genre</span>, <span style='background:red;mso-highlight:red'>publisher</span>,
     <span style='background:red;mso-highlight:red'>release year </span>and <span
     style='background:red;mso-highlight:red'>supported platforms</span>. </span></span>Users
     <span class=SpellE>can</span> <span style='background:yellow;mso-highlight:
     yellow'>download</span>, <span class=SpellE><span style='background:yellow;
     mso-highlight:yellow'>play</span></span><span style='background:yellow;
     mso-highlight:yellow'> </span>and <span class=SpellE>eventually</span> <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>complete</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span><span class=SpellE>them</span>.<o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span lang=EN-US
     style='background:red;mso-highlight:red;mso-ansi-language:EN-US'><span
     style='mso-spacerun:yes'> </span>Apps </span><span lang=EN-US
     style='mso-ansi-language:EN-US'>with information about their <span
     style='background:red;mso-highlight:red'>title</span>, <span
     style='background:red;mso-highlight:red'>version</span>, <span
     style='background:red;mso-highlight:red'>publisher</span>, <span
     style='background:red;mso-highlight:red'>supported platforms </span>and
     file size. </span><span style='background:red;mso-highlight:red'>Users </span><span
     class=SpellE>can</span> <span style='background:yellow;mso-highlight:yellow'>download
     </span>and <span class=SpellE><span style='background:yellow;mso-highlight:
     yellow'>execute</span></span><span style='background:yellow;mso-highlight:
     yellow'> </span><span class=SpellE>them</span><o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span style='mso-ansi-language:
     EN-US'><span style='mso-spacerun:yes'> </span><span lang=EN-US
     style='background:red;mso-highlight:red'>Podcasts</span><span lang=EN-US>
     with information about their <span style='background:red;mso-highlight:
     red'>title</span>, <span style='background:red;mso-highlight:red'>release
     y</span>ear, <span style='background:red;mso-highlight:red'>host</span>(s),
     <span style='background:red;mso-highlight:red'>guest</span>(s), <span
     style='background:red;mso-highlight:red'>episode number </span>and <span
     style='background:red;mso-highlight:red'>language</span>. <span
     style='background:red;mso-highlight:red'>Users</span> can <span
     style='background:yellow;mso-highlight:yellow'>download </span>and <span
     style='background:yellow;mso-highlight:yellow'>listen </span>to an <span
     style='background:red;mso-highlight:red'>episode</span> and <span
     style='background:yellow;mso-highlight:yellow'>complete </span>it.<o:p></o:p></span></span></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span lang=EN-US
     style='mso-ansi-language:EN-US'><span style='mso-spacerun:yes'> </span></span><span
     style='background:red;mso-highlight:red'>Images</span> with information <span
     class=SpellE>about</span> <span class=SpellE>their</span> <span
     class=SpellE><span style='background:red;mso-highlight:red'>title</span></span>,
     <span style='background:red;mso-highlight:red'>resolution</span>, <span
     style='background:red;mso-highlight:red'>file format</span>, <span
     style='background:red;mso-highlight:red'>file <span class=SpellE>size</span>
     </span>and <span style='background:red;mso-highlight:red'>date </span><span
     class=SpellE>taken</span>. <span style='background:red;mso-highlight:red'>Users
     </span><span class=SpellE>can</span> <span style='background:yellow;
     mso-highlight:yellow'>download </span>and <span style='background:yellow;
     mso-highlight:yellow'>display </span>an <span style='background:red;
     mso-highlight:red'>image</span><o:p></o:p></li>
</ul>

<p class=MsoNormal><span style='background:red;mso-highlight:red'>Users </span><span
class=SpellE>should</span> <span class=SpellE>be</span> <span class=SpellE>able</span>
to <span class=SpellE><span style='background:yellow;mso-highlight:yellow'>borrow</span></span><span
style='background:yellow;mso-highlight:yellow'> </span>all <span
style='background:red;mso-highlight:red'>media items</span>, and <span
class=SpellE>only</span> users <span class=SpellE>who</span> have <span
class=SpellE><span style='background:yellow;mso-highlight:yellow'>borrowed</span></span>
an <span style='background:red;mso-highlight:red'>item</span> <span
class=SpellE>may</span> <span style='background:yellow;mso-highlight:yellow'>rate
</span>it.<o:p></o:p></p>

<p class=MsoNormal>The <span style='background:red;mso-highlight:red'>system </span>must
<span class=SpellE>also</span> <span style='background:yellow;mso-highlight:
yellow'>support </span><span class=SpellE>two</span> <span class=SpellE><span
style='background:red;mso-highlight:red'>categories</span></span><span
style='background:red;mso-highlight:red'> </span>of <span style='background:
red;mso-highlight:red'>users</span>: <span class=SpellE><span style='background:
red;mso-highlight:red'>Admin</span></span>, <span class=SpellE><span
style='background:red;mso-highlight:red'>Employee</span></span><span
style='background:red;mso-highlight:red'> </span>and <span class=SpellE><span
style='background:red;mso-highlight:red'>Borrower</span></span>. For <span
class=SpellE>each</span> of <span class=SpellE>these</span> the <span
style='background:red;mso-highlight:red'>system </span><span class=SpellE>needs</span>
to <span class=SpellE><span style='background:yellow;mso-highlight:yellow'>know</span></span><span
style='background:yellow;mso-highlight:yellow'> </span>the <span class=SpellE><span
style='background:red;mso-highlight:red'>name</span></span>, <span
style='background:red;mso-highlight:red'>age</span> and <span style='background:
red;mso-highlight:red'>social security <span class=SpellE>number</span></span>.
As a <span class=SpellE><span style='background:red;mso-highlight:red'>starting</span></span><span
style='background:red;mso-highlight:red'> point</span>, <span style='background:
red;mso-highlight:red'>user</span> <span class=SpellE>authentication</span> is
not <span class=SpellE>required</span>. <span class=SpellE>However</span> on
startup, the <span style='background:red;mso-highlight:red'>program</span> <span
class=SpellE>should</span> <span style='background:yellow;mso-highlight:yellow'>ask</span>
the user to <span class=SpellE><span style='background:yellow;mso-highlight:
yellow'>identify</span></span> <span class=SpellE>their</span> <span
class=SpellE><span style='background:red;mso-highlight:red'>role</span></span>.<o:p></o:p></p>

<ul style='margin-top:0cm' type=disc>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span
     style='mso-spacerun:yes'> </span><span class=SpellE><span
     style='background:red;mso-highlight:red'>Borrower</span></span><span
     style='background:red;mso-highlight:red'> </span><span class=SpellE><span
     style='background:yellow;mso-highlight:yellow'>interact</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>with the <span
     class=SpellE><span style='background:red;mso-highlight:red'>collection</span></span><span
     style='background:red;mso-highlight:red'> </span>by <span class=SpellE><span
     style='background:yellow;mso-highlight:yellow'>listing</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span><span
     style='background:red;mso-highlight:red'>items</span> by <span
     style='background:red;mso-highlight:red'>type</span>, <span class=SpellE><span
     style='background:yellow;mso-highlight:yellow'>selecting</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>and <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>previewing</span></span><span
     style='background:yellow;mso-highlight:yellow'> <span class=SpellE>details</span></span>,
     <span style='background:yellow;mso-highlight:yellow'>rating </span>items,
     and <span class=SpellE><span style='background:yellow;mso-highlight:yellow'>performing</span></span><span
     style='background:yellow;mso-highlight:yellow'> actions </span><span
     class=SpellE>specific</span> to the <span style='background:red;
     mso-highlight:red'>media type</span>.<o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span
     style='mso-spacerun:yes'> </span><span class=SpellE><span
     style='background:red;mso-highlight:red'>Employee</span></span><span
     style='background:red;mso-highlight:red'> </span>is <span class=SpellE>responsible</span>
     for <span class=SpellE><span style='background:yellow;mso-highlight:yellow'>managing</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>the <span
     class=SpellE><span style='background:red;mso-highlight:red'>collection</span></span><span
     style='background:red;mso-highlight:red'> </span>with the <span
     class=SpellE>ability</span> to <span class=SpellE><span style='background:
     yellow;mso-highlight:yellow'>add</span></span><span style='background:
     yellow;mso-highlight:yellow'> </span>or <span class=SpellE><span
     style='background:yellow;mso-highlight:yellow'>remove</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>media items<o:p></o:p></li>
 <li class=MsoNormal style='mso-list:l0 level1 lfo1'><span
     style='mso-spacerun:yes'> </span><span class=SpellE><span
     style='background:red;mso-highlight:red'>Admin</span></span><span
     style='background:red;mso-highlight:red'> </span>has all of an <span
     class=SpellE><span style='background:red;mso-highlight:red'>Employee s</span></span><span
     style='background:red;mso-highlight:red'> </span><span class=SpellE>rights</span>
     and <span class=SpellE>can</span> <span class=SpellE>additionally</span> <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>manage</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span><span class=SpellE>Borrowers</span>
     and <span class=SpellE><span style='background:red;mso-highlight:red'>Employees</span></span>.
     <span style='background:red;mso-highlight:red'>Management </span>covers <span
     style='background:yellow;mso-highlight:yellow'>viewing</span>, <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>creating</span></span>,
     <span style='background:yellow;mso-highlight:yellow'>deleting</span>, <span
     class=SpellE><span style='background:yellow;mso-highlight:yellow'>updating</span></span><span
     style='background:yellow;mso-highlight:yellow'> </span>the <span
     class=SpellE>personal</span> information of users.<o:p></o:p></li>
</ul>

<p class=MsoNormal>The <span class=SpellE>supported</span> actions <span
class=SpellE>should</span> <span class=SpellE>be</span> <span style='background:
yellow;mso-highlight:yellow'>made <span class=SpellE>available</span></span> to
all <span style='background:red;mso-highlight:red'>user</span> <span
class=SpellE><span style='background:red;mso-highlight:red'>categories</span></span><span
style='background:red;mso-highlight:red'> </span>in a clear and <span
class=SpellE>structured</span> <span class=SpellE>way</span>.<o:p></o:p></p>

<p class=MsoNormal>The <span class=SpellE><span style='background:red;
mso-highlight:red'>console</span></span> <span style='background:red;
mso-highlight:red'>interface</span> <span class=SpellE>should</span> <span
style='background:yellow;mso-highlight:yellow'>guide</span> the <span
style='background:red;mso-highlight:red'>user </span>with clear <span
class=SpellE><span style='background:red;mso-highlight:red'>instructions</span></span><span
style='background:red;mso-highlight:red'> </span>and <span class=SpellE><span
style='background:yellow;mso-highlight:yellow'>validate</span></span> all <span
style='background:red;mso-highlight:red'>inputs</span>. <span class=SpellE><span
style='background:red;mso-highlight:red'>Errors</span></span><span
style='background:red;mso-highlight:red'> </span>or invalid <span
style='background:red;mso-highlight:red'>actions </span><span class=SpellE>should</span>
not <span class=SpellE><span style='background:yellow;mso-highlight:yellow'>pass</span></span>
<span class=SpellE>this</span> <span style='background:red;mso-highlight:red'>filter</span>.
The <span style='background:red;mso-highlight:red'>design </span><span
class=SpellE>should</span> <span class=SpellE><span style='background:yellow;
mso-highlight:yellow'>anticipate</span></span> <span class=SpellE>growth</span>
<span class=SpellE>through</span> <span class=SpellE>extensibility</span>, <span
class=SpellE><span style='background:yellow;mso-highlight:yellow'>ensuring</span></span>
<span class=SpellE>that</span> new <span style='background:red;mso-highlight:
red'>media types </span>or <span style='background:red;mso-highlight:red'>user <span
class=SpellE>roles</span> </span><span class=SpellE>can</span> <span
class=SpellE>be</span> <span class=SpellE><span style='background:yellow;
mso-highlight:yellow'>added</span></span> <span class=SpellE>without</span> <span
class=SpellE><span style='background:yellow;mso-highlight:yellow'>disrupting</span></span>
<span class=SpellE>existing</span> <span class=SpellE>functionality</span>.</p>

</div>

</body>

</html>
```