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

<h1><span style="background-color:red">Noun</span> / <mark>Verb</mark></h1>

<p>Sønderborg’s <span style="background-color:red">library</span> <span style="background-color:yellow">aims</span> to <span style="background-color:yellow">launch</span> a digital <span style="background-color:red">platform</span> to <span style="background-color:yellow">manage</span> and <span style="background-color:yellow">share</span> its diverse digital <span style="background-color:red">media</span> <span style="background-color:red">collection</span>. The <span style="background-color:red">system</span> <span style="background-color:yellow">should support</span> multiple <span style="background-color:red">types</span> of <span style="background-color:red">media</span>, including:</p>

<ul>
 <li><span style="background-color:red">E‑books</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">author</span>, <span style="background-color:red">language</span>, <span style="background-color:red">number</span> of <span style="background-color:red">pages</span>, <span style="background-color:red">year</span> of <span style="background-color:red">publication</span> and <span style="background-color:red">ISBN</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">view</span>, <span style="background-color:yellow">download</span> and <span style="background-color:yellow">read</span> them.</li>
 <li><span style="background-color:red">Movies</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">director</span>, <span style="background-color:red">genres</span>, <span style="background-color:red">release year</span>, <span style="background-color:red">language</span> and <span style="background-color:red">duration</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">watch</span> and <span style="background-color:yellow">download</span> them.</li>
 <li><span style="background-color:red">Songs</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">composer</span>, <span style="background-color:red">singer</span>, <span style="background-color:red">genre</span>, <span style="background-color:red">file type</span>, <span style="background-color:red">duration</span> and <span style="background-color:red">language</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">play</span> and <span style="background-color:red">download</span> them.</li>
 <li><span style="background-color:red">Video‑games</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">genre</span>, <span style="background-color:red">publisher</span>, <span style="background-color:red">release year</span> and <span style="background-color:red">supported platforms</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">download</span>, <span style="background-color:yellow">play</span> and eventually <span style="background-color:yellow">complete</span> them.</li>
 <li><span style="background-color:red">Apps</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">version</span>, <span style="background-color:red">publisher</span>, <span style="background-color:red">supported platforms</span> and <span style="background-color:red">file size</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">download</span> and <span style="background-color:yellow">execute</span> them</li>
 <li><span style="background-color:red">Podcasts</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">release year</span>, <span style="background-color:red">host(s)</span>, <span style="background-color:red">guest(s)</span>, <span style="background-color:red">episode number</span> and <span style="background-color:red">language</span>. <span style="background-color:red">Users</span> can <span style="background-color:yellow">download</span> and <span style="background-color:yellow">listen</span> to an <span style="background-color:red">episode</span> and <span style="background-color:yellow">complete</span> it.</li>
 <li><span style="background-color:red">Images</span> with <span style="background-color:red">information</span> about their <span style="background-color:red">title</span>, <span style="background-color:red">resolution</span>, <span style="background-color:red">file format</span>, <span style="background-color:red">file size</span> and <span style="background-color:red">date</span> taken. <span style="background-color:red">Users</span> can <span style="background-color:yellow">download</span> and <span style="background-color:yellow">display</span> an <span style="background-color:red">image</span></li>
</ul>

<p><span style="background-color:red">Users</span> <span style="background-color:yellow">should be</span> able to <span style="background-color:yellow">borrow</span> all <span style="background-color:red">media items</span>, and only <span style="background-color:red">users</span> who have <span style="background-color:yellow">borrowed</span> an <span style="background-color:red">item</span> may <span style="background-color:yellow">rate</span> it.</p>

<p>The <span style="background-color:red">system</span> <span style="background-color:yellow">must</span> also <span style="background-color:yellow">support</span> two <span style="background-color:red">categories</span> of <span style="background-color:red">users</span>: <span style="background-color:red">Admin</span>, <span style="background-color:red">Employee</span> and <span style="background-color:red">Borrower</span>. For each of these the <span style="background-color:red">system</span> <span style="background-color:yellow">needs</span> to <span style="background-color:yellow">know</span> the <span style="background-color:red">name</span>, <span style="background-color:red">age</span> and <span style="background-color:red">social security number</span>. As a <span style="background-color:red">starting point</span>, <span style="background-color:red">user</span> <span style="background-color:red">authentication</span> is not <span style="background-color:yellow">required</span>. However on startup, the <span style="background-color:red">program</span> <span style="background-color:yellow">should ask</span> the <span style="background-color:red">user</span> to <span style="background-color:yellow">identify</span> their <span style="background-color:red">role</span>.</p>

<ul>
 <li><span style="background-color:red">Borrower</span> <span style="background-color:yellow">interact</span> with the <span style="background-color:red">collection</span> by <span style="background-color:yellow">listing items</span> by <span style="background-color:red">type</span>, <span style="background-color:yellow">selecting</span> and <span style="background-color:yellow">previewing details</span>, <span style="background-color:yellow">rating</span> items, and <span style="background-color:yellow">performing actions</span> specific to the <span style="background-color:red">media type</span>.</li>
 <li><span style="background-color:red">Employee</span> <span style="background-color:yellow">is</span> responsible for <span style="background-color:yellow">managing</span> the <span style="background-color:red">collection</span> with the ability to <span style="background-color:yellow">add</span> or <span style="background-color:yellow">remove</span> <span style="background-color:red">media</span> items</li>
 <li><span style="background-color:red">Admin</span> <span style="background-color:yellow">has</span> all of an <span style="background-color:red">Employee’s</span> <span style="background-color:red">rights</span> and can additionally <span style="background-color:yellow">manage</span> <span style="background-color:red">Borrowers</span> and <span style="background-color:red">Employees</span>. <span style="background-color:red">Management</span> covers <span style="background-color:yellow">viewing</span>, <span style="background-color:yellow">creating</span>, <span style="background-color:yellow">deleting</span>, <span style="background-color:yellow">updating</span> the personal <span style="background-color:red">information</span> of <span style="background-color:red">users</span>.</li>
</ul>

<p>The supported <span style="background-color:red">actions</span> <span style="background-color:yellow">should be made available</span> to all <span style="background-color:red">user categories</span> in a clear and structured way.</p>

<p>The <span style="background-color:red">console interface</span> <span style="background-color:yellow">should guide</span> the <span style="background-color:red">user</span> with clear <span style="background-color:red">instructions</span> and <span style="background-color:yellow">validate</span> all <span style="background-color:red">inputs</span>. <span style="background-color:red">Errors</span> or invalid <span style="background-color:red">actions</span> <span style="background-color:yellow">should not pass</span> this <span style="background-color:red">filter</span>. The <span style="background-color:red">design</span> <span style="background-color:yellow">should anticipate</span> <span style="background-color:red">growth</span> through <span style="background-color:red">extensibility</span>, <span style="background-color:yellow">ensuring</span> that new <span style="background-color:red">media types</span> or <span style="background-color:red">user roles</span> can be <span style="background-color:yellow">added</span> without <span style="background-color:yellow">disrupting</span> existing <span style="background-color:red">functionality</span>.</p>