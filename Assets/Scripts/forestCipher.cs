﻿using Words;
public class forestCipher : cipherBase
{
    protected override string Name { get { return "Forest"; } }

    private static int moduleIdCounter = 1;

    protected override void Initialize()
    {
        moduleId = moduleIdCounter++;
        answer = new Data().PickWord(6);
        Log("FOREST", "Answer: {0}", answer);
        pages = forestcipher(answer);
    }
}
