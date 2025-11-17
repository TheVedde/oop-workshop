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