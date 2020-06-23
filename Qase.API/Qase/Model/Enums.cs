using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model
{
  public enum AccessLevel
  {
    All,
    Group,
    None
  }

  public enum Severity
  {
    Undefined,
    Blocker,
    Critical,
    Major,
    Normal,
    Minor,
    Trivial
  }

  public enum Priority
  {
    Undefined,
    High,
    Medium,
    Low
  }

  public enum TypeCase
  {
    Other,
    Functional,
    Smoke,
    Regression,
    Security,
    Usability,
    Performance,
    Acceptance
  }

  public enum Behavior
  {
    Undefined,
    Positive,
    Negative,
    Destructive
  }

  public enum Automation
  {
    is_not_automated,
    automated,
    to_be_automated,
  }
}
