# Rules Engine Pattern

This Pattern is implemented to response this [issue](https://github.com/ardalis/DesignPatternsInCSharp/issues/15)

The [Lroca88](https://github.com/Lroca88):

> *It would be nice if you could extended the content a little more with a short-circuiting and a priority example.*
>
> *Just an example that comes to my mind while writing this.
Let's say that a customer has referred another costumer and for that, you want to check if a ReferralRule applies before any other rule, the reason we wanted to be the first rule evaluated, is because in that case we wouldn't want to apply any other rule. Even the birthday rule would need to be omitted due to the 30% discount that ReferralRule presents.*

[ardalis](https://github.com/ardalis)

> *Sure, there are a couple of ways to approach this.*
>
> *We want this rule to run first and short-circuit if it applies
This referral rule with its 30% discount is currently the best discount available, but that might not always be true. We want to make sure the customer gets the best discount they're eligible for
I think you're mainly interested in the first case; the second one just involves running all the rules and keeping the best/biggest discount.*
>
> *I'll add an example showing the #1 approach and how you could implement it. Thanks!*