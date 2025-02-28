﻿namespace AntiOllvm.entity;

public class Operand
{
    
  public  Arm64OperandKind kind;
  public string operand_str;
  public string registerName;
  public long immediateValue;
  public long pcRelativeValue;
  public int shiftValue;
  public Arm64ShiftType shiftType;
  public Arm64ConditionCode conditionCode;
  public MemoryOperand memoryOperand;
  
  public bool IsZeroRegister()
  {
    return registerName=="XZR" || registerName=="WZR";
  }
  public override string ToString()
  {
    switch (kind)
    {
      case  Arm64OperandKind.Register:
        return "Register: " + registerName;
      case Arm64OperandKind.Immediate:
        return "Immediate: " + immediateValue;
      case Arm64OperandKind.VectorRegisterElement:
        return "VectorRegisterElement";
      case Arm64OperandKind.Memory:
        return "Memory: " + memoryOperand.registerName + " " + memoryOperand.addend;
    }
    return "Unknown";
  }
}