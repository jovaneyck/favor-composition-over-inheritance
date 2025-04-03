# favor-composition-over-inheritance
Code kata to highlight the tradeoffs between inheritance and composition

Accompanying material available [here](https://docs.google.com/presentation/d/1-IL4q0fQLZ8V3LO3t62WhsTfhzGVnXGPSoYypUmm_gI/edit?usp=sharing).

# Exercise

This exercise is comprised of multiple steps that build on top of each other. Don't look ahead!
The tests are there to easily run to code. If something is hard to write a test for, don't bother with them. Writing good unit tests is not the focus of this exercise.

<details>
<summary>Step 1</summary>

### Add logging to the httpclient

Use inheritance to add logging, try not to change too much of the existing HttpClient class.
You can use Console.WriteLine (or XUnit's *ITestOutputHelper*), no need to grab for Serilog 😉
</details>

<details>
<summary>Step 2</summary>

### Add caching to the httpclient

Use inheritance to add caching.
**The customer has guaranteed that we'll never ever ever need both logging and caching at the same time.** In fact, the customer would be displeased if our product would do both logging and caching at the same time.
</details>

<details>
<summary>Step 3</summary>

### The customer changes their mind

Sometimes it would make sense to use both logging and caching. Can you think of a solution where we can enable logging, caching, or both using inheritance?
You don't have to fully implement this step if 30 minutes have already passed, but do form on opinion on how we would be able to tackle this.
</details>

<details>
<summary>Step 4</summary>

### Let's try again using composition

We won't be using the current code, *git reset --hard*

Try the first three steps again, but this time use composition instead of inheritance. This time you can fully work out step 3.
</details>
