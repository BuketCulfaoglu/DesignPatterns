﻿namespace VisitorPattern;

public abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}