### Changelog

All notable changes to this project will be documented in this file. Dates are displayed in UTC.

Generated by [`auto-changelog`](https://github.com/CookPete/auto-changelog).

#### [0.7.0](https://github.com/route1rodent/newbark/compare/0.6.1...0.7.0)

> 11 October 2019

- revamp sprites and tiles, add Cherry Grove city [`9152ec3`](https://github.com/route1rodent/newbark/commit/9152ec3f673c27869bd7dd57cf47d42708b0b350)
- delete outdated presets [`5b51d68`](https://github.com/route1rodent/newbark/commit/5b51d68e25df908db87d2cc74d29a184cffe778f)
- fix interactables positions [`365a649`](https://github.com/route1rodent/newbark/commit/365a649a59faaaebba894a6b3a1fd3d2267adba0)
- use 2D extras as Unity Package [`82d6433`](https://github.com/route1rodent/newbark/commit/82d6433417c7baa8f6a6ae1a207fc33660357a02)
- reorganize code under the RPGKit2D namespace [`db079ae`](https://github.com/route1rodent/newbark/commit/db079ae9c0a11aa3acfa1dd9caf83beb924218d5)
- implement multi-layer audio channel support + area music change [`8e65d69`](https://github.com/route1rodent/newbark/commit/8e65d69bf1c177f87d1c60896e5c74e0f6e25a4c)
- add Interactable layer. reorganise layers, tags and grid. [`322b4ec`](https://github.com/route1rodent/newbark/commit/322b4eca258d9e99dbe7beff9f571f4da1039135)
- move scripts to new (WIP) 2d-rpgkit package [`be006e2`](https://github.com/route1rodent/newbark/commit/be006e28510c621433fa1a94786c7a4ec2e5ec68)
- separate Interactable logic into a separate controller [`199f1f4`](https://github.com/route1rodent/newbark/commit/199f1f48fc3058ba3f341bc8dc8411168f3e7b36)
- implement event-based collision sound [`897dc18`](https://github.com/route1rodent/newbark/commit/897dc18518a428d3e5c0a3606f57fe37003dc421)
- simplify the MovementController in one single script [`40ba58f`](https://github.com/route1rodent/newbark/commit/40ba58f9db87cd24a18949533ee1fa07526a09ad)
- add new AnimationController and RPGKit namespace [`41f1b61`](https://github.com/route1rodent/newbark/commit/41f1b61ba4e86005e7285a14f23b58a6d4fc45a4)
- fix camera bounds to perfect rectangle [`2f7905d`](https://github.com/route1rodent/newbark/commit/2f7905da33a872c14be948e4b1f2d9dfbad15383)
- remove unnecessary Gizmos [`0094c83`](https://github.com/route1rodent/newbark/commit/0094c83a8ad9b057a2b97d9751bf9d2619f30f23)
- fix dialog scrolling issues [`a02a555`](https://github.com/route1rodent/newbark/commit/a02a55551c7a6dfe0561849f0f904c5ae924bb2f)
- move scripts under NewBark namespace [`340c913`](https://github.com/route1rodent/newbark/commit/340c913be9068dfaf5a8600d7629158e3ae748e1)
- fix: dialog trigger should not end on B button press [`0d14a40`](https://github.com/route1rodent/newbark/commit/0d14a408321db4f57dd7f1e8045a797a7944c111)
- stop forcing resolution [`a02d8f6`](https://github.com/route1rodent/newbark/commit/a02d8f616c304cdc500a27fa19cb112064459b49)
- rename Input class [`aee929e`](https://github.com/route1rodent/newbark/commit/aee929e69f620427cfc32bfbe848374954f4365e)
- fix animation CycleOffset (initial leg move sync) [`0abe5c0`](https://github.com/route1rodent/newbark/commit/0abe5c090297a472e800e26c4719035ee6bacb1b)
- upgrade editor to 2019.2.8f1 [`e679b5d`](https://github.com/route1rodent/newbark/commit/e679b5dfc91f85b8070f318de553036103fd6878)
- change README [`3bbab06`](https://github.com/route1rodent/newbark/commit/3bbab06cdb3f72a171ce8f417ff4a78bca65d2da)
- remove old debug logs [`a05ef78`](https://github.com/route1rodent/newbark/commit/a05ef785fd6a661e7b3c2044f2d8c463cd709c4c)
- change Helpers menu to 2D RPG Kit [`32efc16`](https://github.com/route1rodent/newbark/commit/32efc16f04336e8cad1fa4cdb0e29ed5ade418ab)

#### [0.6.1](https://github.com/route1rodent/newbark/compare/0.6.0...0.6.1)

> 19 August 2019

- warping improvements I [`f248ad6`](https://github.com/route1rodent/newbark/commit/f248ad64d8e29b6e253999fbf3c09b0f536c3f61)
- add initial screen fader implementation [`f33277d`](https://github.com/route1rodent/newbark/commit/f33277d11badcb03a8577f818c04ce68e0097566)
- fix current warp direction issues [`93d7471`](https://github.com/route1rodent/newbark/commit/93d74719051a1fc6134b2f5e4ac4aca0a3a1b7fe)
- add GUI prefabs [`9800afa`](https://github.com/route1rodent/newbark/commit/9800afa53414c83b72e568d1490e560c7f391652)
- add splash screen, app icon and force resolution [`64fe5cb`](https://github.com/route1rodent/newbark/commit/64fe5cbe67177cf9d20bbf2e128fb2aa06f39877)
- warping improvements II [`c5fde90`](https://github.com/route1rodent/newbark/commit/c5fde906965af2e64a79c9ca23f7b8b16044d6a0)
- update to Unity 2019.1.9 [`ca99302`](https://github.com/route1rodent/newbark/commit/ca9930230e455d664ed560ef3352b45d1b377d1a)
- warping improvements III [`a1b974c`](https://github.com/route1rodent/newbark/commit/a1b974c1637d3c2f09978e5a3deda68f7908603e)
- fix fade and end warp direction [`ab2ca4e`](https://github.com/route1rodent/newbark/commit/ab2ca4ed4508680c938bc990e0e791da8a415190)
- add IDE filter by tag helper [`c4c2d15`](https://github.com/route1rodent/newbark/commit/c4c2d151862b886b7459c5d95e31ff1698992bfe)
- initial touch/swipe input support [`b6400c1`](https://github.com/route1rodent/newbark/commit/b6400c10aa936f22aef288cd1b2d63d97329ae70)
- warp only Player tagged objects [`19de3dd`](https://github.com/route1rodent/newbark/commit/19de3dd54b49b3b40eec67888bd242881a2900b9)
- update to Unity 2019.2.1f1 [`9951275`](https://github.com/route1rodent/newbark/commit/99512753c8035e7a5a440f4857e5cf31ac4f5b08)
- update package versions and readme [`405906f`](https://github.com/route1rodent/newbark/commit/405906faa08ea73eafc020e40212cedbc8318c71)
- add dev notes file [`ec63808`](https://github.com/route1rodent/newbark/commit/ec638088cf5bc87a1b6f38386a2d8ee04aa93bcf)
- fix build [`ad5aad2`](https://github.com/route1rodent/newbark/commit/ad5aad2c8452dd7ba3d2fe69ec815e6681ca9937)
- optimize HasComponent function [`482f049`](https://github.com/route1rodent/newbark/commit/482f04940c1325bb9bb6815c3433be6e0ed25f70)
- rename physics scripts folder to movement [`d069044`](https://github.com/route1rodent/newbark/commit/d06904452f1815718f70da48c4293a9bd30080c1)

#### [0.6.0](https://github.com/route1rodent/newbark/compare/0.5.0...0.6.0)

> 7 February 2019

- add initial Dialog system [`e14800f`](https://github.com/route1rodent/newbark/commit/e14800f7f3600d163e87fb57a1d3c0dc8c7fde0f)
- fixed map, item collision and vsync [`b2c286a`](https://github.com/route1rodent/newbark/commit/b2c286a6fbf31f683592687d80aae052b65daac0)
- dialog improvements with auto text wrap and scroll [`62a23b7`](https://github.com/route1rodent/newbark/commit/62a23b79aa08e88df2fb052d1a1a25604ac23904)
- Dialog box system improvements [`a42fc46`](https://github.com/route1rodent/newbark/commit/a42fc464ee0e058e53dd7e5d776ad6672257f6d1)
- update pkgs [`b3dd939`](https://github.com/route1rodent/newbark/commit/b3dd939b2da986ac3c62d34dba43e105455ed717)
- fix: dont move on GUI [`9bbbbcf`](https://github.com/route1rodent/newbark/commit/9bbbbcfa1a359ad35a757817014b979231888cb9)
- remove material from UI [`a2aa445`](https://github.com/route1rodent/newbark/commit/a2aa445eb118227f5a9662f52e146bc2c6c1c74d)

#### [0.5.0](https://github.com/route1rodent/newbark/compare/0.1.0-melonjs...0.5.0)

> 25 January 2019

- NewBark v0.5.0 [`#12`](https://github.com/route1rodent/newbark/pull/12)
- Merge pull request #12 from capsulemonsters/develop [`#7`](https://github.com/route1rodent/newbark/issues/7) [`#11`](https://github.com/route1rodent/newbark/issues/11) [`#2`](https://github.com/route1rodent/newbark/issues/2) [`#6`](https://github.com/route1rodent/newbark/issues/6)
- initial port and migration to Unity [`bc3aee6`](https://github.com/route1rodent/newbark/commit/bc3aee6453ad52ffe465aa46d89788f70fb017e0)
- corner tiles + audio [`061cf4c`](https://github.com/route1rodent/newbark/commit/061cf4c615887974e41d0709994932b3de53f92b)
- improved collision detection engine [`4fbd138`](https://github.com/route1rodent/newbark/commit/4fbd138a0f50ab00a627dbb38f07c42239c2c197)
- add blender tree player animation [`6fe7abc`](https://github.com/route1rodent/newbark/commit/6fe7abce0cf5f7395dd4931c7722a3aefebb59ba)
- delegate the actual movement outside CellMovement class [`d6854f3`](https://github.com/route1rodent/newbark/commit/d6854f3a5fa011bc21afc31642445f60f62dd199)
- better camera movement and bounds [`c8c7c2e`](https://github.com/route1rodent/newbark/commit/c8c7c2ec082beb0f2c1f2519a3d40cfca67920e9)
- fix: prevent player rotation and collision fricition and stay [`a68d258`](https://github.com/route1rodent/newbark/commit/a68d258eb8997b65f9d2a721d96c33e292414ac8)
- attempt to fix tile jitter on camera move [`068276e`](https://github.com/route1rodent/newbark/commit/068276ef30b1fbb3fbe7e5246c14938c14838eba)
- added sound support for collisions + layer bug fixes [`88e41ea`](https://github.com/route1rodent/newbark/commit/88e41ea215f03c84143c27eb8b3afb491786b1a2)
- refactor: grid movement into modular classes [`74453cc`](https://github.com/route1rodent/newbark/commit/74453cc1744b672f0fb28c16c004de4f2b3448d0)
- rename Assets/Vendor to Assets/Packages [`2e471d7`](https://github.com/route1rodent/newbark/commit/2e471d75a06dbb6d796911dfad86002316e2d024)
- update to Unity 2018.2.19f1 [`355b135`](https://github.com/route1rodent/newbark/commit/355b1350eb324d51e38e971913032b54243efcf7)
- remove unused script [`d1d2165`](https://github.com/route1rodent/newbark/commit/d1d21658c4d6f99b00d811b06601a4e208796db4)
- more precise camera size + disable EditorOnly objects renderer [`2634366`](https://github.com/route1rodent/newbark/commit/26343667a26b5eff36aad53c24cc0c0df6101a95)
- better camera support, less jitter [`0fc91cc`](https://github.com/route1rodent/newbark/commit/0fc91cc96b69bf6d20ab324571aa73f64606b57e)
- Update to Unity 2018.3.2f1 [`24a8bb2`](https://github.com/route1rodent/newbark/commit/24a8bb2d917ef6b8bad9662a63e370ea1266fc52)
- reorganise scripts [`2f83b9c`](https://github.com/route1rodent/newbark/commit/2f83b9c89fe1a34c58df0a4ca76329d20f14e70d)
- readme update [`81b07a9`](https://github.com/route1rodent/newbark/commit/81b07a96c40368d9dae8548318d74b31b60e9c99)
- fix README links [`46c90ba`](https://github.com/route1rodent/newbark/commit/46c90ba3e0eb4018dd13bac9d588d46c89ed000c)
- Update README.md [`41e67be`](https://github.com/route1rodent/newbark/commit/41e67bed80afffca08966ba9a11c99d7f2693008)
- fix warnings in RuleTileEditor component [`0f93b02`](https://github.com/route1rodent/newbark/commit/0f93b02e53c9cff41556bcab23268f4dd5a77b68)
- Update README.md [`8c35b2f`](https://github.com/route1rodent/newbark/commit/8c35b2f8cb0b972dc0cde4beaf81fea37e343086)
- Update recommendations.md [`f8e9194`](https://github.com/route1rodent/newbark/commit/f8e919467b9a3118e0763227d1aab50afa111f54)

#### 0.1.0-melonjs

> 27 March 2018

- fix: issues with debug sprite and fps and grid snapping movement [`#1`](https://github.com/route1rodent/newbark/issues/1) [`#5`](https://github.com/route1rodent/newbark/issues/5)
- refactor: webpack + gulp integration, modularization of the game [`7dd1650`](https://github.com/route1rodent/newbark/commit/7dd16506c30a7d80d9f1079bb28c7a1f55bc762b)
- initial engine with map [`2c234d3`](https://github.com/route1rodent/newbark/commit/2c234d3b91235767a862a51e4f94fb69e48b998a)
- refactor: code is now fully modular [`2fba4d7`](https://github.com/route1rodent/newbark/commit/2fba4d725e442e98dcbe60ed8a0a8d31ffae5eb7)
- refactoring: Entities and Controllable engine [`649ddcc`](https://github.com/route1rodent/newbark/commit/649ddcc807874d59ab3207bbc37069679d47de62)
- fix: Grid movement and collision engines now work properly, but at 32fps [`232c4a1`](https://github.com/route1rodent/newbark/commit/232c4a1997c3873c88b71c39e7a0b8aae119158c)
- refactor: Game and GameLoader classes into more modular code [`664f575`](https://github.com/route1rodent/newbark/commit/664f575f08a20671b5f9d7bf077125eaa1b9820b)
- refactor: improves external module handling and gulp scripts [`0c994e7`](https://github.com/route1rodent/newbark/commit/0c994e7e34831d41856ce4d834436fd3cb3521db)
- refactor: movement calculations have been simplified, with speed support [`0104867`](https://github.com/route1rodent/newbark/commit/0104867225cd7af41540e629c224fdcf3e2b3b96)
- feat: improved assets object access [`c495ba3`](https://github.com/route1rodent/newbark/commit/c495ba30dcda095df6e397e343c3587e349073c5)
- assets: adds Pokemon GB fonts, remove unused. [`1460610`](https://github.com/route1rodent/newbark/commit/146061027361c823905675c1207c0d6982720340)
- refactor: game load is now decoupled [`52bc346`](https://github.com/route1rodent/newbark/commit/52bc3460235d4b1cb3996505f0b96a1f110811de)
- refactor: config is loaded externally now [`7f60b55`](https://github.com/route1rodent/newbark/commit/7f60b55dbe75ce5a6002d5fea636c32c1e51efa3)
- improved index layout [`954f567`](https://github.com/route1rodent/newbark/commit/954f5670e5e79ad0a0acd51d76016659a3bdd854)
- template and debug info improvements [`f38cc86`](https://github.com/route1rodent/newbark/commit/f38cc86b4555b9879a2f65ebd1c8fb402130e7eb)
- adds gulp publish command for admins [`7a1f304`](https://github.com/route1rodent/newbark/commit/7a1f304e628743154079848c051ef217aca89627)
- remove unused files [`f13433d`](https://github.com/route1rodent/newbark/commit/f13433d34d2027315aca823e9cb2acf0b628e2b0)
- style: better syntax [`9cf08dc`](https://github.com/route1rodent/newbark/commit/9cf08dcb8667b7ad72d3c0d74ab9e0999d09d6ec)
- improved layout with SuperGB skins [`a3f2b11`](https://github.com/route1rodent/newbark/commit/a3f2b1114c4ffd3851b584ef35909b3c9869ee0d)
- feat: add initial swipe and touch support [`70329d7`](https://github.com/route1rodent/newbark/commit/70329d7fa601df237a44421bfa3678d79bbf77fa)
- refactor: simpler video resolution and scaling system. fix for HDPI displays. [`98f9ecf`](https://github.com/route1rodent/newbark/commit/98f9ecfc7297984a8c4dcc8eea9e9fb089004775)
- ui: new minimal frame layout [`c18578d`](https://github.com/route1rodent/newbark/commit/c18578d0847904c86a505fd15c3145fd491fa729)
- feature: added Gamepad support [`966532c`](https://github.com/route1rodent/newbark/commit/966532c510297bfc88ce52cc17810803001150b7)
- moves css to the src folder, added gulp watch [`2c343f0`](https://github.com/route1rodent/newbark/commit/2c343f011d6f4313f7f1aea182c44c65a26955fd)
- fix: anchorPoint.set was not called in the Controllable [`f45bc75`](https://github.com/route1rodent/newbark/commit/f45bc7574e504827bcfe4532fffd15cffce272a8)
- remove gamepadjs dependency [`25a3197`](https://github.com/route1rodent/newbark/commit/25a31975696235fa6362dfbff52f06529015a7b4)
- updated README [`e47a03f`](https://github.com/route1rodent/newbark/commit/e47a03f93cc5edfd23908abd7941e19b5a216a85)
- adds license [`97f0bbd`](https://github.com/route1rodent/newbark/commit/97f0bbd50886d9340cfe8ccb549eb2ba68c9a661)
- Improved Gruntfile tasks [`3a5cb56`](https://github.com/route1rodent/newbark/commit/3a5cb564af98492df034cc2613946bc72ad2b90d)
- fix: config file not found in Electron app + footer removal [`74a4fce`](https://github.com/route1rodent/newbark/commit/74a4fce97dbc9021c02fe41f309c38a4a56c1a2a)
- fix: set FPS before load [`34f1125`](https://github.com/route1rodent/newbark/commit/34f1125ef7d07ca25c92dbf6f270e82dd6e4c04e)
- Update index.html [`1312ba9`](https://github.com/route1rodent/newbark/commit/1312ba9a8728dbf3ff242ddcc087f22020dc79c3)
- ui: improved footer [`7526140`](https://github.com/route1rodent/newbark/commit/752614084d4bd7c188c07bd54b6fff92a3fc7b36)
- maps: new player position [`c4baa2e`](https://github.com/route1rodent/newbark/commit/c4baa2ef390c7bc979958154bb26acf785632b63)
- Update README.md [`8502fd9`](https://github.com/route1rodent/newbark/commit/8502fd95f8719def119525625691dabd1473f7ab)
- update gh-pages commit descriptions [`a8466fa`](https://github.com/route1rodent/newbark/commit/a8466fa5b4ae2619faf7edc171098a10b276729e)
- Update README.md [`8e49b4b`](https://github.com/route1rodent/newbark/commit/8e49b4b3eebc76244744d0eae567a940a022a4c1)
- Initial commit [`f5152dd`](https://github.com/route1rodent/newbark/commit/f5152dd7d18b9086b2ba6cdf2d47e0c4e6f5be00)
- update screenshot [`0c09838`](https://github.com/route1rodent/newbark/commit/0c09838948fa6482e51f996c86437c855f7e8096)
