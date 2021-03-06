/*======================================================================
== Copyright : BlueCurve (c)
== Licence   : Gnu/GPL v2.x
== Author    : Teddy Albina
== Email     : bluecurveteam@gmail.com
== Web site  : http://www.codeplex.com/BlueCurve
========================================================================*/

namespace RobotRules
{
    /// <summary>
    ///   Represents an Allow or Disallow rule associated with a partial URI.
    /// </summary>
    internal struct Rule
    {
        /// <summary>
        ///   Initialises a new Rule.
        /// </summary>
        /// <param name="partialUri"> The partial URI to which the rule applies. </param>
        /// <param name="allow"> True if this is an Allow rule, or false for a Disallow rule. </param>
        /// <param name="priority"> The zero-based index of the rule's parent record in the file. </param>
        public Rule(string partialUri, bool allow, int priority)
            : this()
        {
            PartialUri = partialUri;
            Allow = allow;
            Priority = priority;
        }


        /// <summary>
        ///   The partial URI to which the rule applies.
        /// </summary>
        public string PartialUri { get; private set; }

        /// <summary>
        ///   True if this is an Allow rule, or false for a Disallow rule.
        /// </summary>
        public bool Allow { get; private set; }

        /// <summary>
        ///   The zero-based index of the rule's parent record in the robot control file, a lower number indicating an earlier record (which takes priority over any later records that also partially match a given user agent token).
        /// </summary>
        public int Priority { get; private set; }
    }
}