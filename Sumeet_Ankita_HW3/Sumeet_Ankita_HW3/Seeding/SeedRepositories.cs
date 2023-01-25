using Sumeet_Ankita_HW3.DAL;
using Sumeet_Ankita_HW3.Models;
using Sumeet_Ankita_HW3.DAL;
using Sumeet_Ankita_HW3.Models;
using System.Text;

namespace Sumeet_Ankita_HW3.Seeding
{
    public static class SeedRepositories
    {
        public static void SeedAllRepositories(AppDbContext db)
        {
            //Create a new list for all of the repos
            List<Repository> AllRepositories = new List<Repository>();
            AllRepositories.Add(new Repository
            {
                RepositoryName = "ant-design",
                StarCount = 42.162m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "TypeScript"),
                URL = "https://github.com/ant-design/ant-design",
                UserName = "ant-design",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = " A UI Design Language",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "atom",
                StarCount = 47.722m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/atom/atom",
                UserName = "atom",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = ":atom: The hackable text editor",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "free-programming-books-zh_CN",
                StarCount = 44.894m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/justjavac/free-programming-books-zh_CN",
                UserName = "justjavac",
                LastUpdate = new DateTime(2018, 12, 23),
                Description = ":books:",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "free-programming-books",
                StarCount = 117.056m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/EbookFoundation/free-programming-books",
                UserName = "EbookFoundation",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = ":books: Freely available programming books",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "CS-Notes",
                StarCount = 48.804m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/CyC2018/CS-Notes",
                UserName = "CyC2018",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = ":books: ??????????",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "electron",
                StarCount = 69.729m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/electron/electron",
                UserName = "electron",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = ":electron: Build cross-platform desktop apps with JavaScript, HTML, and CSS",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "jekyll",
                StarCount = 36.748m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Ruby"),
                URL = "https://github.com/jekyll/jekyll",
                UserName = "jekyll",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = ":globe_with_meridians: Jekyll is a blog-aware static site generator in Ruby",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "computer-science",
                StarCount = 38.169m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/ossu/computer-science",
                UserName = "ossu",
                LastUpdate = new DateTime(2019, 2, 2),
                Description = ":mortar_board: Path to a free self-taught education in Computer Science!",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "awesome",
                StarCount = 101.289m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/sindresorhus/awesome",
                UserName = "sindresorhus",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = ":sunglasses: Curated list of awesome lists",
                Category = Category.Other,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "You-Dont-Know-JS",
                StarCount = 95.954m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/getify/You-Dont-Know-JS",
                UserName = "getify",
                LastUpdate = new DateTime(2019, 1, 23),
                Description = "A book series on JavaScript. @YDKJS on twitter.",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "webpack",
                StarCount = 46.891m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/webpack/webpack",
                UserName = "webpack",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A bundler for javascript and friends. Packs many modules into a few bundled assets. Code Splitting allows for loading parts of the application on demand. Through loaders, modules can be CommonJs, AMD, ES6 modules, CSS, Images, JSON, Coffeescript, LESS, ... and your custom stuff.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "every-programmer-should-know",
                StarCount = 36.5m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/mtdvio/every-programmer-should-know",
                UserName = "mtdvio",
                LastUpdate = new DateTime(2019, 2, 3),
                Description = "A collection of (mostly) technical things every software developer should know",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "gitignore",
                StarCount = 78.636m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/github/gitignore",
                UserName = "github",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "A collection of useful .gitignore templates",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "public-apis",
                StarCount = 48.943m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/toddmotto/public-apis",
                UserName = "toddmotto",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A collective list of free APIs for use in software and web development.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "coding-interview-university",
                StarCount = 73.955m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/jwasham/coding-interview-university",
                UserName = "jwasham",
                LastUpdate = new DateTime(2019, 2, 3),
                Description = "A complete computer science study plan to become a software engineer.",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "awesome-go",
                StarCount = 39.658m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Go"),
                URL = "https://github.com/avelino/awesome-go",
                UserName = "avelino",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A curated list of awesome Go frameworks, libraries and software",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "awesome-machine-learning",
                StarCount = 37.959m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/josephmisiti/awesome-machine-learning",
                UserName = "josephmisiti",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "A curated list of awesome Machine Learning frameworks, libraries and software.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "awesome-python",
                StarCount = 61.118m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/vinta/awesome-python",
                UserName = "vinta",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A curated list of awesome Python frameworks, libraries, software and resources",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "react",
                StarCount = 121.696m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/facebook/react",
                UserName = "facebook",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A declarative, efficient, and flexible JavaScript library for building user interfaces.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "oh-my-zsh",
                StarCount = 82.994m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Shell"),
                URL = "https://github.com/robbyrussell/oh-my-zsh",
                UserName = "robbyrussell",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "A delightful community-driven (with 1,200+ contributors) framework for managing your zsh configuration. Includes 200+ optional plugins (rails, git, OSX, hub, capistrano, brew, ant, php, python, etc), over 140 themes to spice up your morning, and an auto-update tool so that makes it easy to keep up with the latest updates from the community.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "react-native",
                StarCount = 73.594m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/facebook/react-native",
                UserName = "facebook",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "A framework for building native apps with React.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "Front-end-Developer-Interview-Questions",
                StarCount = 39.065m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "HTML"),
                URL = "https://github.com/h5bp/Front-end-Developer-Interview-Questions",
                UserName = "h5bp",
                LastUpdate = new DateTime(2019, 1, 9),
                Description = "A list of helpful front-end related questions you can use to interview potential candidates, test yourself or completely ignore.",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "normalize.css",
                StarCount = 33.903m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "CSS"),
                URL = "https://github.com/necolas/normalize.css",
                UserName = "necolas",
                LastUpdate = new DateTime(2019, 1, 3),
                Description = "A modern alternative to CSS resets",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "lodash",
                StarCount = 37.208m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/lodash/lodash",
                UserName = "lodash",
                LastUpdate = new DateTime(2019, 2, 1),
                Description = "A modern JavaScript utility library delivering modularity, performance, & extras.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "laravel",
                StarCount = 49.098m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "PHP"),
                URL = "https://github.com/laravel/laravel",
                UserName = "laravel",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "A PHP framework for web artisans",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "html5-boilerplate",
                StarCount = 42.078m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/h5bp/html5-boilerplate",
                UserName = "h5bp",
                LastUpdate = new DateTime(2019, 1, 29),
                Description = "A professional front-end template for building fast, robust, and adaptable web apps or sites.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "element",
                StarCount = 34.881m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Vue"),
                URL = "https://github.com/ElemeFE/element",
                UserName = "ElemeFE",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "A Vue.js 2.0 UI Toolkit for Web",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "javascript-algorithms",
                StarCount = 43.952m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/trekhleb/javascript-algorithms",
                UserName = "trekhleb",
                LastUpdate = new DateTime(2019, 2, 1),
                Description = "Algorithms and data structures implemented in JavaScript with explanations and links to further readings",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "tensorflow",
                StarCount = 120.117m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/tensorflow/tensorflow",
                UserName = "tensorflow",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "An Open Source Machine Learning Framework for Everyone",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "x64dbg",
                StarCount = 33.587m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/x64dbg/x64dbg",
                UserName = "x64dbg",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "An open-source x64/x32 debugger for windows.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "angular.js",
                StarCount = 59.37m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/angular/angular.js",
                UserName = "angular",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "AngularJS - HTML enhanced for web apps!",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "ansible",
                StarCount = 35.22m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/ansible/ansible",
                UserName = "ansible",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Ansible is a radically simple IT automation platform that makes your applications and systems easier to deploy. Avoid writing scripts or custom code to deploy and update your applications � automate in a language that approaches plain English, using SSH, with no agents to install on remote systems. https://docs.ansible.com/ansible/",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "httpie",
                StarCount = 39.674m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/jakubroztocil/httpie",
                UserName = "jakubroztocil",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "As easy as httpie /aitch-tee-tee-pie/Modern command line HTTP client � user-friendly curl alternative with intuitive UI, JSON support, syntax highlighting, wget-like downloads, extensions, etc. https://twitter.com/clihttp",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "bitcoin",
                StarCount = 37.023m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/bitcoin/bitcoin",
                UserName = "bitcoin",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Bitcoin Core integration/staging tree",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "d3",
                StarCount = 82.209m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/d3/d3",
                UserName = "d3",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "Bring data to life with SVG, Canvas and HTML. :bar_chart::chart_with_upwards_trend::tada:",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "ionic",
                StarCount = 36.914m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "HTML"),
                URL = "https://github.com/ionic-team/ionic",
                UserName = "ionic-team",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Build amazing native and progressive web apps with open web technologies. One app running on everything ??",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "nw.js",
                StarCount = 34.982m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/nwjs/nw.js",
                UserName = "nwjs",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Call all Node.js modules directly from DOM/WebWorker and enable a new way of writing applications with all Web technologies.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "youtube-dl",
                StarCount = 46.923m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/rg3/youtube-dl",
                UserName = "rg3",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Command-line program to download videos from YouTube.com and other video sites",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "30-seconds-of-code",
                StarCount = 38.379m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/30-seconds/30-seconds-of-code",
                UserName = "30-seconds",
                LastUpdate = new DateTime(2019, 1, 26),
                Description = "Curated collection of useful JavaScript snippets that you can understand in 30 seconds or less.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "react-router",
                StarCount = 34.674m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/ReactTraining/react-router",
                UserName = "ReactTraining",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Declarative routing for React",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "keras",
                StarCount = 38.005m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/keras-team/keras",
                UserName = "keras-team",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Deep Learning for humans",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "java-design-patterns",
                StarCount = 44.191m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Java"),
                URL = "https://github.com/iluwatar/java-design-patterns",
                UserName = "iluwatar",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Design patterns implemented in Java",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "rust",
                StarCount = 33.845m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Rust"),
                URL = "https://github.com/rust-lang/rust",
                UserName = "rust-lang",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Empowering everyone to build reliable and efficient software.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "yarn",
                StarCount = 34.69m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/yarnpkg/yarn",
                UserName = "yarnpkg",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Fast, reliable, and secure dependency management.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "express",
                StarCount = 42.268m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/expressjs/express",
                UserName = "expressjs",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "Fast, unopinionated, minimalist web framework for node.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "flutter",
                StarCount = 52.52m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Dart"),
                URL = "https://github.com/flutter/flutter",
                UserName = "flutter",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Flutter makes it easy and fast to build beautiful mobile apps.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "json-server",
                StarCount = 37.946m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/typicode/json-server",
                UserName = "typicode",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "Get a full fake REST API with zero coding in less than 30 seconds (seriously)",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "markdown-here",
                StarCount = 35.325m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/adam-p/markdown-here",
                UserName = "adam-p",
                LastUpdate = new DateTime(2018, 11, 13),
                Description = "Google Chrome, Firefox, and Thunderbird extension that lets you write email in Markdown and render it before sending.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "puppeteer",
                StarCount = 45.024m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/GoogleChrome/puppeteer",
                UserName = "GoogleChrome",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Headless Chrome Node API",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "storybook",
                StarCount = 33.705m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/storybooks/storybook",
                UserName = "storybooks",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Interactive UI component dev & test: React, React Native, Vue, Angular, Ember",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "impress.js",
                StarCount = 34.452m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/impress/impress.js",
                UserName = "impress",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "It's a presentation framework based on the power of CSS3 transforms and transitions in modern browsers and inspired by the idea behind prezi.com.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "three.js",
                StarCount = 48.54m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/mrdoob/three.js",
                UserName = "mrdoob",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "JavaScript 3D library.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "javascript",
                StarCount = 81.402m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/airbnb/javascript",
                UserName = "airbnb",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "JavaScript Style Guide",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "jquery",
                StarCount = 50.871m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/jquery/jquery",
                UserName = "jquery",
                LastUpdate = new DateTime(2019, 1, 29),
                Description = "jQuery JavaScript Library",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "system-design-primer",
                StarCount = 56.523m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/donnemartin/system-design-primer",
                UserName = "donnemartin",
                LastUpdate = new DateTime(2019, 2, 3),
                Description = "Learn how to design large-scale systems. Prep for the system design interview. Includes Anki flashcards.",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "linux",
                StarCount = 69.031m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C"),
                URL = "https://github.com/torvalds/linux",
                UserName = "torvalds",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Linux kernel source tree",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "thefuck",
                StarCount = 40.709m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/nvbn/thefuck",
                UserName = "nvbn",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Magnificent app which corrects your previous console command.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "the-art-of-command-line",
                StarCount = 38.701m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/jlevy/the-art-of-command-line",
                UserName = "jlevy",
                LastUpdate = new DateTime(2019, 1, 15),
                Description = "Master the command line, in one page",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "material-design-icons",
                StarCount = 37.088m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "CSS"),
                URL = "https://github.com/google/material-design-icons",
                UserName = "google",
                LastUpdate = new DateTime(2019, 1, 10),
                Description = "Material Design icons by Google",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "materialize",
                StarCount = 35.015m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/Dogfalo/materialize",
                UserName = "Dogfalo",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "Materialize, a CSS Framework based on Material Design",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "meteor",
                StarCount = 40.741m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/meteor/meteor",
                UserName = "meteor",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "Meteor, the JavaScript App Platform",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "moby",
                StarCount = 52.082m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Go"),
                URL = "https://github.com/moby/moby",
                UserName = "moby",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Moby Project - a collaborative project for the container ecosystem to assemble container-based systems",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "models",
                StarCount = 48.06m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/tensorflow/models",
                UserName = "tensorflow",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Models and examples built with TensorFlow",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "node-v0.x-archive",
                StarCount = 35.612m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/nodejs/node-v0.x-archive",
                UserName = "nodejs",
                LastUpdate = new DateTime(2018, 4, 4),
                Description = "Moved to https://github.com/nodejs/node",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "node",
                StarCount = 57.948m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/nodejs/node",
                UserName = "nodejs",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Node.js JavaScript runtime :sparkles::turtle::rocket::sparkles:",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "angular",
                StarCount = 45.046m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "TypeScript"),
                URL = "https://github.com/angular/angular",
                UserName = "angular",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "One framework. Mobile & desktop.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "elasticsearch",
                StarCount = 38.18m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Java"),
                URL = "https://github.com/elastic/elasticsearch",
                UserName = "elastic",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Open Source, Distributed, RESTful Search Engine",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "moment",
                StarCount = 40.07m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/moment/moment",
                UserName = "moment",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Parse, validate, manipulate, and display dates in javascript.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "redux",
                StarCount = 46.684m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/reduxjs/redux",
                UserName = "reduxjs",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "Predictable state container for JavaScript apps",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "kubernetes",
                StarCount = 47.863m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Go"),
                URL = "https://github.com/kubernetes/kubernetes",
                UserName = "kubernetes",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Production-Grade Container Scheduling and Management",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "axios",
                StarCount = 54.682m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/axios/axios",
                UserName = "axios",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Promise based HTTP client for the browser and node.js",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "requests",
                StarCount = 37.037m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/requests/requests",
                UserName = "requests",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "Python HTTP Requests for Humans",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "material-ui",
                StarCount = 44.189m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/mui-org/material-ui",
                UserName = "mui-org",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "React components that implement Google's Material Design.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "socket.io",
                StarCount = 45.113m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/socketio/socket.io",
                UserName = "socketio",
                LastUpdate = new DateTime(2019, 1, 19),
                Description = "Realtime application framework (Node.JS server)",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "netdata",
                StarCount = 35.281m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C"),
                URL = "https://github.com/netdata/netdata",
                UserName = "netdata",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Real-time performance monitoring, done right! https://my-netdata.io/",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "redis",
                StarCount = 34.144m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C"),
                URL = "https://github.com/antirez/redis",
                UserName = "antirez",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Redis is an in-memory database that persists on disk. The data model is key-value, but many different kind of values are supported: Strings, Lists, Sets, Sorted Sets, Hashes, HyperLogLogs, Bitmaps.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "resume.github.com",
                StarCount = 39.39m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/resume/resume.github.com",
                UserName = "resume",
                LastUpdate = new DateTime(2018, 12, 29),
                Description = "Resumes generated using the GitHub informations",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "developer-roadmap",
                StarCount = 71.788m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/kamranahmedse/developer-roadmap",
                UserName = "kamranahmedse",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Roadmap to becoming a web developer in 2019",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "rails",
                StarCount = 42.075m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Ruby"),
                URL = "https://github.com/rails/rails",
                UserName = "rails",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Ruby on Rails",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "RxJava",
                StarCount = 37.49m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Java"),
                URL = "https://github.com/ReactiveX/RxJava",
                UserName = "ReactiveX",
                LastUpdate = new DateTime(2019, 2, 5),
                Description = "RxJava � Reactive Extensions for the JVM � a library for composing asynchronous and event-based programs using observable sequences for the Java VM.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "Semantic-UI",
                StarCount = 44.388m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/Semantic-Org/Semantic-UI",
                UserName = "Semantic-Org",
                LastUpdate = new DateTime(2019, 1, 22),
                Description = "Semantic is a UI component framework based around useful principles from natural language.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "create-react-app",
                StarCount = 63.142m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/facebook/create-react-app",
                UserName = "facebook",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Set up a modern web app by running one command.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "Chart.js",
                StarCount = 41.642m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/chartjs/Chart.js",
                UserName = "chartjs",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Simple HTML5 Charts using the <canvas> tag",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "spring-boot",
                StarCount = 33.865m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Java"),
                URL = "https://github.com/spring-projects/spring-boot",
                UserName = "spring-projects",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "Spring Boot",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "go",
                StarCount = 52.834m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Go"),
                URL = "https://github.com/golang/go",
                UserName = "golang",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "The Go programming language",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "reveal.js",
                StarCount = 44.544m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/hakimel/reveal.js",
                UserName = "hakimel",
                LastUpdate = new DateTime(2019, 2, 2),
                Description = "The HTML Presentation Framework",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "freeCodeCamp",
                StarCount = 297.277m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/freeCodeCamp/freeCodeCamp",
                UserName = "freeCodeCamp",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "The https://www.freeCodeCamp.org open source codebase and curriculum. Learn to code for free together with millions of people.",
                Category = Category.Education,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "Font-Awesome",
                StarCount = 58.709m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/FortAwesome/Font-Awesome",
                UserName = "FortAwesome",
                LastUpdate = new DateTime(2019, 2, 1),
                Description = "The iconic SVG, font, and CSS toolkit",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "bootstrap",
                StarCount = 130.513m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "CSS"),
                URL = "https://github.com/twbs/bootstrap",
                UserName = "twbs",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "The most popular HTML, CSS, and JavaScript framework for developing responsive, mobile first projects on the web.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "flask",
                StarCount = 41.75m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/pallets/flask",
                UserName = "pallets",
                LastUpdate = new DateTime(2019, 1, 25),
                Description = "The Python micro framework for building web applications.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "next.js",
                StarCount = 34.326m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/zeit/next.js",
                UserName = "zeit",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "The React Framework",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "swift",
                StarCount = 46.566m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "C++"),
                URL = "https://github.com/apple/swift",
                UserName = "apple",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "The Swift Programming Language",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "django",
                StarCount = 39.301m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Python"),
                URL = "https://github.com/django/django",
                UserName = "django",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "The Web framework for perfectionists with deadlines.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "TypeScript",
                StarCount = 44.695m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "TypeScript"),
                URL = "https://github.com/Microsoft/TypeScript",
                UserName = "Microsoft",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "TypeScript is a superset of JavaScript that compiles to clean JavaScript output.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "vscode",
                StarCount = 68.569m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "TypeScript"),
                URL = "https://github.com/Microsoft/vscode",
                UserName = "Microsoft",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "Visual Studio Code",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "animate.css",
                StarCount = 57.242m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "CSS"),
                URL = "https://github.com/daneden/animate.css",
                UserName = "daneden",
                LastUpdate = new DateTime(2019, 1, 19),
                Description = "?? A cross-browser library of CSS animations. As easy to use as an easy thing.",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "awesome-vue",
                StarCount = 42.097m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/vuejs/awesome-vue",
                UserName = "vuejs",
                LastUpdate = new DateTime(2019, 2, 6),
                Description = "?? A curated list of awesome things related to Vue.js",
                Category = Category.Resources,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "lantern",
                StarCount = 40.007m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Go"),
                URL = "https://github.com/getlantern/lantern",
                UserName = "getlantern",
                LastUpdate = new DateTime(2019, 1, 23),
                Description = "?????????? https://github.com/getlantern/download ?? Lantern Latest Download https://github.com/getlantern/download ",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "vue",
                StarCount = 127.224m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "JavaScript"),
                URL = "https://github.com/vuejs/vue",
                UserName = "vuejs",
                LastUpdate = new DateTime(2019, 2, 7),
                Description = "?? Vue.js is a progressive, incrementally-adoptable JavaScript framework for building UI on the web.",
                Category = Category.Code,
            });
            AllRepositories.Add(new Repository
            {
                RepositoryName = "build-your-own-x",
                StarCount = 41.99m,
                Language = db.Languages.FirstOrDefault(l => l.LanguageName == "Other"),
                URL = "https://github.com/danistefanovic/build-your-own-x",
                UserName = "danistefanovic",
                LastUpdate = new DateTime(2019, 2, 4),
                Description = "?? Build your own (insert technology here)",
                Category = Category.Resources,
            });

            //create some counters to help debug problems
            Int32 intRepositoryID = 0;
            String strRepositoryName = "Start";

            //loop through the list to add or update the Repository
            try
            {
                foreach (Repository seedRepository in AllRepositories)
                {
                    //update the counters
                    intRepositoryID = seedRepository.RepositoryID;
                    strRepositoryName = seedRepository.RepositoryName;
                    //see if the Repository is already in the database using the RepositoryName
                    Repository dbRepository = db.Repositories.FirstOrDefault(r => r.RepositoryName == seedRepository.RepositoryName);

                    //if repository is null, repository is not in database
                    if (dbRepository == null)
                    {
                        //Add the repository to the database
                        db.Repositories.Add(seedRepository);
                        db.SaveChanges();
                    }
                    else //the repository is in the database - reset all fields except name
                    {
                        dbRepository.StarCount = seedRepository.StarCount;
                        dbRepository.Language = seedRepository.Language;
                        dbRepository.URL = seedRepository.URL;
                        dbRepository.UserName = seedRepository.UserName;
                        dbRepository.LastUpdate = seedRepository.LastUpdate;
                        dbRepository.Description = seedRepository.Description;
                        dbRepository.Category = seedRepository.Category;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) //throw error if there is a problem in the database
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the repository with the title: ");
                msg.Append(strRepositoryName);
                msg.Append(" (RepositoryID: ");
                msg.Append(intRepositoryID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
            }
        }
    }
}
