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
    other,
    functional,
    smoke,
    regression,
    security,
    usability,
    performance,
    acceptance
  }

  public enum Behavior
  {
    Undefined,
    Positive,
    Negative,
    Destructive
  }

  //public enum Automation
  //{
  //  is_not_automated,
  //  automated,
  //  to_be_automated,
  //}

  public enum TestCaseStatus
  {
    Actual,
    Draft,
    Deprecated,
  }

  public enum TypeFilter
  {
    search,
    milestone_id,
    suite_id,
    severity,
    priority,
    type,
    behavior,
    automation,
    status,
    member,
    run,
    case_id,
    from_end_time,
    to_end_time
  }

  public enum StatusTestRun
  {
    active, 
    complete, 
    abort
  }

  public enum StatusTestRunResult
  {
    in_progress, 
    passed, 
    failed, 
    blocked
  }

  public enum StatusDefect
  {
    open, 
    resolved
  }

  public enum StatusMilestone
  {
    active,
    completed
  }
}
