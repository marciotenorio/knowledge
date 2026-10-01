---
name: document-algorithms
description: Document algorithm methods for later reference, including standard method documentation, asymptotic analysis, and relevant technical properties. Use when asked to document algorithm code or improve its documentation. Give a description easy to understand, but without losing information.
---

# Document algorithms

Document the actual implementation, not just the textbook algorithm.
Modify documentation only unless code changes are explicitly requested.
Use the existing documentation language, defaulting to English.

For C#, place standard XML documentation comments above each method.
For other languages, use their conventional documentation format.

## Documentation structure

1. Summary
   - Explain the method's purpose and algorithm.
   - State ordering, the processed range, and whether input is modified.

2. Parameters and return value
   - Document every parameter and type parameter.
   - Explain valid ranges and required preconditions.
   - Distinguish array length from a processed prefix or slice.
   - Explain return values and sentinel values.
   - Omit return documentation for void methods.

3. Exceptions
   - Document relevant exceptions supported by the code.
   - Distinguish checked arguments from unchecked preconditions.
   - Do not claim validation that the implementation does not perform.

4. Approach
   - Briefly explain how the algorithm works.
   - Include a useful invariant when it aids understanding.

5. Asymptotic analysis
   - Define variables, such as n being the number of processed elements.
   - State time complexity using Big-O notation.
   - Give best, average, and worst cases when applicable and justified.
   - Combine cases when their bounds are identical.
   - State assumptions behind average, expected, or amortized bounds.
   - Briefly explain the bounds using the actual implementation.
   - Include helper operations, early exits, and comparison costs.
   - State auxiliary space, including recursion and temporary storage.
   - Distinguish auxiliary space from input and output storage.

6. Relevant technical properties
   - For sorting, state stability and explain why equal-key elements
     do or do not retain their original relative order.
   - Determine stability from comparisons and element movement.
   - State whether the algorithm is in-place and what it modifies.
   - Mention adaptiveness or other properties when useful and supported.
   - For other algorithms, include applicable requirements such as
     sorted input, graph restrictions, or duplicate handling.
   - Explain meaningful edge cases without inventing guarantees.

## C# formatting

Use summary, typeparam, param, returns, and exception XML tags as
appropriate. Put approach, complexity, and properties in remarks,
using labeled para elements.

Use valid XML and escape special characters. Match parameter names
exactly to the method signature.

## Verification

Check documentation claims against the method and relevant helpers.
If code is incomplete or incorrect, report the limitation rather
than documenting intended behavior as fact.

Review the diff to ensure executable code remains unchanged.
