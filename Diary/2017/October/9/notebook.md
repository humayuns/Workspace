# 9-10-2017

## Bisection Method

![Bisection Method](250px-Bisection_method.svg.png)
Algorithm
```
INPUT: Function f, endpoint values a, b, tolerance TOL, maximum iterations NMAX
CONDITIONS: a < b, either f(a) < 0 and f(b) > 0 or f(a) > 0 and f(b) < 0
OUTPUT: value which differs from a root of f(x)=0 by less than TOL
 
N ← 1
While N ≤ NMAX # limit iterations to prevent infinite loop
  c ← (a + b)/2 # new midpoint
  If f(c) = 0 or (b – a)/2 < TOL then # solution found
    Output(c)
    Stop
  EndIf
  N ← N + 1 # increment step counter
  If sign(f(c)) = sign(f(a)) then a ← c else b ← c # new interval
EndWhile
Output("Method failed.") # max number of steps exceeded
```

## Writing Mathematic Fomulars in Markdown

```
\int_0^\infty \mathrm{e}^{-x}\,\mathrm{d}x

\to
```

## MathMorphs

![MathMorphs](http://www.dm.uba.ar/MathMorphs/morphic.gif)

## Squeak: Install Metacello

```smalltalk
"Get the Metacello configuration (for Squeak users)"
Installer gemsource
    project: 'metacello';
    addPackage: 'ConfigurationOfMetacello';
    install.

"Bootstrap Metacello Preview, using mcz files (#'previewBootstrap' symbolic version"
((Smalltalk at: #ConfigurationOfMetacello) project 
  version: #'previewBootstrap') load.

"Load the Preview version of Metacello from GitHub"
(Smalltalk at: #Metacello) new
  configuration: 'MetacelloPreview';
  version: #stable;
  repository: 'github://dalehenrich/metacello-work:configuration';
  load.

"Now load latest version of Metacello"
(Smalltalk at: #Metacello) new
  baseline: 'Metacello';
  repository: 'github://dalehenrich/metacello-work:master/repository';
  get.
(Smalltalk at: #Metacello) new
  baseline: 'Metacello';
  repository: 'github://dalehenrich/metacello-work:master/repository';
  load.
```

## Pharo: Tetris
A simple Tetris implementation. [Link](http://catalog.pharo.org/catalog/project/Tetris?_s=yoLwV9g2FUGYCA5C&_k=yr8IdgxXHNGn6k7R)

![Tetris](tetris.png)
```smalltalk
"Install package"
Metacello new
	smalltalkhubUser: 'Pharo' project: 'MetaRepoForPharo40';
	configuration: 'Tetris';
	version: #stable;
	load.

"run new game"	
Tetris new openInWorld.
```

## Links
* https://en.wikipedia.org/wiki/Bisection_method
* http://csrgxtu.github.io/2015/03/20/Writing-Mathematic-Fomulars-in-Markdown/
* http://www.dm.uba.ar/MathMorphs/
* https://github.com/dalehenrich/metacello-work
* http://www.opencobalt.net/
* :bolt: https://github.com/SquareBracketAssociates/SqueakByExample-english