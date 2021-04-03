function checkBracketsMatch(input)
{
    // input must be a string
    if (!(typeof input === "string"))
    {
        return false;
    }

    // assumes all other characters are ignored
    var missingMatch = [];
    for (var i = 0; i < input.length; i++) {
        var c = input.charAt(i);

        if (c === "(") {
            missingMatch.push(")");
        } else if (c === "[") {
            missingMatch.push("]");
        } else if (c === "{") {
            missingMatch.push("}");
        } else if (c === ")" || c === "]" || c === "}") {
            if (missingMatch.length === 0 || c !== missingMatch.pop()) {
                return false;
            }
        }
    }

    return missingMatch.length === 0;
}
