<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="blog_integration_demo.aspx.cs" Inherits="DocuVieware_webform_app_demo.BlogIntegrationDemo" %>

<%@ Register Assembly="GdPicture.NET.14.WEB.DocuVieware" Namespace="GdPicture14.WEB" TagPrefix="cc1" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>DocuVieware - Blog Integration Demo.</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="favicon.ico" rel="icon" />
    <link href="style/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="style/demos.css" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Droid+Serif|Montserrat" rel="stylesheet" type="text/css">
</head>
<body>
    <div id="header">
        <div id="logo-header">
            <a href="/">
                <img src="img/docuvieware-logo-home-x2.png" width="310" height="50" class="logo" alt="DocuVieware Logo" />
            </a>
        </div>
        <div id="header-desc">
            <h1>Universal HTML5 Viewer and Document Management Kit</h1>
            <p class="version">
                Blog Integration Demo • Version: <asp:Label ID="dvVersion" runat="server" Text="[VERSION]"></asp:Label>
            </p>
        </div>
    </div>
    <div class="container">
        <div class="row ligne2">
            <article>
                <header>
                    <h1>Bugs</h1>
                    <p>
                        Hi folks,<br />
                        I remember one of Jerry Seinfeld's stand-up comedy moments when he was being perplexed by the fact that women, 
						who basically can take boiling hot wax, pour it on their legs and rip the hair out by the roots, can still be afraid of bugs.
						Well, maybe same paradox can somehow be extrapolated to software developers and software bugs too.
						But why and what are these software "bugs" anyway?
                    </p>
                </header>
                <section>
                    <p>
                        In <a title="ORPALIS Blog - The First Compiler" href="http://www.orpalis.com/blog/the-first-compiler/" target="_blank">one of our older articles </a>
                        we've told you about how the word "<em>bug</em>" came to express computer malfunctioning. It originally applied for hardware-related malfunctions but 
						then the short-and-catchy term quickly came to designate software-related malfunctions and inaugurated the gallery of creatures in software domain, 
						which also includes <a title="ORPALIS Blog - Of Viruses And Men" href="http://www.orpalis.com/blog/viruses-men/" target="_blank">viruses</a>, 
						worms, spiders and other <a title="Web Crawlers" href="http://en.wikipedia.org/wiki/Web_crawler" target="_blank">crawlers</a>.
						But unlike those, which are created on purpose, bugs are created by mistake.
                    </p>
                    <p>
                        Bugs are errors (or defects, flaws, faults) within a software code that, depending on the magnitude of the mistake in code design or 
						writing can produce effects in system's behavior ranging from annoying or inconvenient up to almost catastrophic.
                    </p>
                    <p>
                        Probably the most famous bug is the <a title="Year 2000 Problem" href="http://en.wikipedia.org/wiki/Year_2000_problem" target="_blank">Millenium Bug</a> aka "<em>Y2K</em>".
						It was a design flaw: in order to increase simplicity, many professional programmers of the decades preceding year 2000 used to express the year 
						within a date by using 2 digits only. So for example, year 1986 was expressed as "86" by many computer programs. A quite rational thing to do, 
						actually, except that when year 2000 was to come, it would have been expressed as year "00" that is, indistinguishable from year 1900 and breaking 
						the increasing numbers logic (ie, 96, 97, 98, 99, 00).  Well, believe it or not, this bug issue was so serious it determined a coordinated worldwide 
						response (as if it were an alien bug from space coming to destroy humankind like in a B movie from Hollywood).
                    </p>
                    <p>
                        An <em>International Y2K Cooperation Center</em> was established, reuniting 120 countries and being funded by the World Bank.
						It is estimated that global costs for avoiding a potential disaster exceeded 400 Billion USD in today's money.
						But disaster prevention efforts can pay off in unpredictable ways: when the September 11th 2001 tragedy happened, New York's infrastructure continued 
						to be operational <a title="MIT.edu" href="http://newsoffice.mit.edu/2002/terror-1120" target="_blank">thanks to networks redundancy and backup plans</a>
                        originally devised to deal with worst-case scenarios of the Y2K bug impact. Needless to say this now, after hundreds of billion bucks spent and a global 
						emotional warming, nothing bad happened (except for the usual stuff, of course).
                    </p>
                    <div class="docuvieware-player">
                        <form id="form2" runat="server" style="width: 100%; height: 100%;">
                            <cc1:DocuVieware ID="DocuVieware1" runat="server"
                                Height="100%"
                                Width="100%"
                                SinglePageView="false"
                                ToolbarBackColor="#FFFFFF"
                                EnableFileUploadButton="False"
                                EnableLoadFromUriButton="False"
                                EnableRotateButtons="False"
                                EnableFitPageButton="False"
                                EnableFitWidthButton="False"
                                EnableZoom100Button="False"
                                EnableAnnotationsButton="False"
                                EnableTextSearch="False"
                                ShowAnnotationsSnapIn="False"
                                ShowTextSearchSnapIn="False"
                                ShowThumbnailsSnapIn="False"
                                EnableMultipleThumbnailSelection="True"
                                CollapsedSnapIn="True"
                                ShowBookmarksSnapIn="False"
                                EnableMouseModeButtons="False"
                                EnableTwainAcquisitionButton="False"
                                EnableFormFieldsEdition="False" />
                        </form>
                    </div>
                    <p>
                        Thing is, if you think that such ridiculous situation is singular you'd better think again: have you ever heard about the 
                        <a title="Year 2038 Problem" href="http://en.wikipedia.org/wiki/Year_2038_problem" target="_blank">Year 2038 Problem</a>?
                    </p>
                    <p>
                        Well, this problem is related to the <em>C</em> programming language and the way it handles time values.
						The standard time library of routines in C uses a 4-byte format (32-bit long, that is) to handle (calculate, convert and store) time values as seconds. 
						Being limited by definition (ie, the maximum number) this format was set to assume that Time started on January 1st 1970 at 12:00 AM. 
						So all time/date values are conveniently (for a computer) calculated as seconds with respect to this date. 
						Problem is however that the maximum length of time is the biggest 31-bit binary value (the 32-nd bit is used to express "+" or "-") which in decimals 
						means 2,147,483,647 seconds (2 ^31), which added to the "zero moment" translates into 19 January 2038. Most 32-bit 
                        <a title="Math.Utah.edu" href="http://www.math.utah.edu/~beebe/unix.html" target="_blank">Unix-like systems</a> store and manipulate time in this format 
						so the <em>Year 2038</em> bug mainly concerns the numerous Unix installations and 
                        <a title="Embedded system" href="http://en.wikipedia.org/wiki/Embedded_system" target="_blank">embedded-systems</a> that controle lots of devices like phones, 
						cars, avionics, medical equipment and so on. Moving from 32-bit to 64-bit is one of the proposed solutions but, even if it seems a natural step currently 
						ongoing for computers, it is not as simple for embedded systems' case. But even if the bug's manifestation came into attention quite late (on May 2006 in 
						the '<em>AOLserver</em>' open-source software) the problem is being adressed and it will probably be easier to overcome than the Y2K problem.
                    </p>
                    <p>
                        Well folks, good news is that crises generated by these bugs had (or will have) a happy ending, regardless the costs.
						But bad news is that some other bugs had tragic outcome, like for example the 
                        <a title="Therac-25" href="http://en.wikipedia.org/wiki/Therac-25" target="_blank">THERAC-25 radiation therapy machine</a>
                        (1985-1987) which because of software bugs in both design and development practices, caused the death of at least 4 patients 
						by delivering an amount of radiation 100 times higher than the intended dose.
                    </p>
                    <p>
                        Another example of bugs turning tragic happened in February 1991, when because of 
                        <a title="Sydney.edu - Patriot Missile Software Bug" href="http://sydney.edu.au/engineering/it/~alum/patriot_bug.html" target="_blank">a bug in the targeting software</a>, 
						a Patriot missile failed to assess an Iraqi SCUD missile as "<em>threat</em>" and canceled its interception allowing the SCUD missile to hit its target 
						killing 28 soldiers and injuring further 98. There would be other examples too, but we really don't want to transform this article into a blacklist of casualties 
						and damages caused by software bugs.
                    </p>
                    <p>
                        Instead, we are going to finish by mentioning two bugs discovered very recently which, although not necesarily life-threatening are nonetheless serious.
                    </p>
                    <p>
                        One of them, codenamed "<a title="Heartbleed.com" href="http://heartbleed.com/" target="_blank">Heartbleed</a>" is a security bug in the OpenSSL, 
						an open-source implementation of the Transport Layer Security (TLS) protocol.
                    </p>
                    <p>
                        <a title="OpenSSL" href="http://en.wikipedia.org/wiki/OpenSSL" target="_blank">OpenSSL</a> implementations exists almost everywhere, 
						being used in webservers (like Apache and nginx), Operating Systems (like some Linux distributions including RedHat Enterprise, Oracle Linux, 
						Amazon Linux, Ubuntu or Android 4.1.1), various software applications and firmware.
                    </p>
                    <p>
                        In other words, most major websites and online services in the world 
                        <a title="Heartbleed - Specific systems affected" href="http://en.wikipedia.org/wiki/Heartbleed#Specific_systems_affected" target="_blank">were affected</a>, 
						not to count the client-side vulnerabilities and the less impressive names on the list. Even if the OpenSSL Project was founded in 1998 and despite being 
						open-source the bug was discovered by Neel Mehta from Google as late as April 2014! A fix was developed by Bodo Moeller and Adam Langley from Google 
						(or was it Adam Google from Langley?) but truth is the vast majority of specialists seem to agree that damages produced by this extremely serious security 
						bug are almost impossible to track and estimate.
                    </p>
                    <p>
                        But wait, we're not finished with internet security protocol bugs yet.
						Last month <a title="TheGuardian.com" href="http://www.theguardian.com/technology/2014/oct/15/poodle-web-security-ssl-v3" target="_blank">a new vulnerability was discovered</a> and reported.
                    </p>
                    <p>
                        It was nicknamed POODLE (stands for "<strong>P</strong>adding <strong>O</strong>racle <strong>O</strong>n <strong>D</strong>owngraded <strong>L</strong>egacy <strong>E</strong>ncryption") 
						and even if it's about a flaw in the design of the SSL v.3 algorithms (which were long time replaced by the 
                        <a title="Transport Layer Security" href="http://en.wikipedia.org/wiki/Transport_Layer_Security" target="_blank">TLS</a>
                        as told above), most browsers are still SSL compliant and here's the thing: whenever a failed connection occurs, browsers automatically try a downgraded security protocol... like the vulnerable SSL v.3.
						So unlike Heartbleed (which concerned a particular implementation) the POODLE bug concerns all implementations, either open-source or proprietary, because the vulnerability resides in the very design 
						of the algorithms, which were always public by the way.
                    </p>
                    <p>
                        One long lasting bug, provided it took 18 years to get discovered. But even if it's less dangerous and quite easy to fix it still raises two important questions. 
						One is how serious public specifications and open-source codes are being reviewed by the crowds of contributors. And the other one is how many other such bugs are 
						still being "at large", hidden in plain sight.
                    </p>
                    <p>
                        Well folks, regardless of the answers, we think the one conclusion anybody can draw for this article is that all bugs in software are actual manifestations of the bugs in our heads of course.
                    </p>
                    <p>
                        And, as it seems that we're <a title="MIT Technology Review online" href="http://www.technologyreview.com/view/532156/googles-secretive-deepmind-startup-unveils-a-neural-turing-machine/" target="_blank">making fast progress</a>
                        in designing software able to re-write itself (so presumably also prone to auto-debug and fix), we'd better hurry in paying some more attention to the bugs in our own thinking too.
						Before <a title="pinimg.com" href="http://media-cache-ak0.pinimg.com/originals/55/67/d1/5567d18a0ffc1c2970c3dd4be009157d.jpg" target="_blank">it's too late</a>.
                    </p>
                    <p>
                        Bye!
                    </p>
                </section>
                <hr class="footer-blog-hr">
                <footer>
                    <img src="img/bogdan.jpg" alt="Author">
                    <div id="footer-article-author">
                        <h3>Bogdan Nemteanu</h3>
                        <p><a href="http://www.orpalis.com/labs/about-the-team.php">Story-teller.</a></p>
                    </div>
                </footer>
            </article>
        </div>
    </div>
</body>
</html>
