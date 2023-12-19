using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace MockOne
{
    /// <summary>
    /// namespace level Node class creation for the tree data structure usage
    /// </summary>
    public class ClassificationNode
    {
        public ClassificationNode Parent { get; set; }
        public string Class { get; set; }
        public Stack<ClassificationNode> Subclass { get; set; }

     
        public class ClassificationRunner
    {
            /// <summary>
            /// Random number generator used for generating random values or indices.
            /// Globally declated objects for global use
            /// </summary>
        private Stack<ClassificationNode> classes;
        private Stack<ClassificationNode> QuizOptions;
        private ClassificationNode QuizQuestion;
        private Random random = new Random();

            public ClassificationRunner()
        {
            this.classes = new Stack<ClassificationNode>();
            ReadFromJSONFile("call_number_classification.json");
        }

            /// <summary>
            /// Generates the next unique quiz question and its corresponding options.
            public void GenerateNextUniqueQuizQuestion()
        {
            if (QuizQuestion == null)
            {
                QuizQuestion = RetrieveUniqueSubclass(classes);
            }
            else
            {                if (QuizQuestion.Subclass.Any())
                {
                    QuizQuestion = RetrieveUniqueSubclass(QuizQuestion.Subclass);
                }
                else
                {
                    QuizQuestion = RetrieveUniqueSubclass(classes);
                }
            }

           
            QuizOptions = UniqueOptions(QuizQuestion);
        }


            /// <summary>
            /// adaptted from https://stackoverflow.com/questions/13306968/check-if-a-string-is-null-or-empty-otherwise-trim-it
            /// </summary>
            /// <returns></returns>
            public string RetrieveUniqueQuestion()
        {
                return QuizQuestion != null ? QuizQuestion.Class.Substring(3).Trim() : string.Empty;
            }

            /// <summary>
            /// adapted from: https://stackoverflow.com/questions/20675469/tolist-after-select-in-linq
            /// </summary>
            /// <returns></returns>
            public List<string> UniqueQuizOptions()
        {
            return QuizOptions.Select(option => option.Class).ToList();
        }


            /// <summary>
            /// Validates the user's answer against the class name of the top-level parent node of the quiz question. Logic Adapted from: https://stackoverflow.com/questions/12624666/method-with-a-bool-return
            /// </summary>
            /// <param name="userAnswer">The user's answer to validate.</param>
            /// <returns>True if the user's answer matches the class name, false otherwise.</returns>
            public bool ValidateUserAnswer(string userAnswer)
            {
                // Get the top-level parent of the current question
                ClassificationNode uniqueTopParent = UniqueTopParent(QuizQuestion);

                // Implement the logic to check the answer
                if (uniqueTopParent != null)
                {
                    return IsUserAnswerCorrect(uniqueTopParent, userAnswer);
                }

                return false;
            }

            /// <summary>
            /// Checks if the user's answer matches the class name of the top-level parent node. Adapted from: https://stackoverflow.com/questions/63562617/what-should-be-the-return-value-of-stringcomparison-ordinalignorecase
            /// </summary>
            /// <param name="topParent">The top-level parent node of the quiz question.</param>
            /// <param name="userAnswer">The user's answer to compare.</param>
            /// <returns>True if the user's answer matches the class name, false otherwise.</returns>
            private bool IsUserAnswerCorrect(ClassificationNode topParent, string userAnswer)
            {
                return topParent.Class.Equals(userAnswer, StringComparison.OrdinalIgnoreCase);
            }


            /// <summary>
            /// Retrieves the top-level parent node of a given class node.
            /// </summary>
            /// <param name="className">The class node for which to retrieve the top-level parent.</param>
            /// <returns>The top-level parent node of the class node, or null if the input is null.</returns>            
            private ClassificationNode UniqueTopParent(ClassificationNode className)
            {
                if (className == null)
                {
                    return null;
                }

                ClassificationNode topParent = className;
                while (topParent.Parent != null)
                {
                    topParent = topParent.Parent;
                }

                return topParent;
            }


            /// <summary>
            /// Retrieves a random unique third-level subclass from the provided stack of class categories.
            /// </summary>
            /// <param name="classCategories">The stack of class categories.</param>
            /// <returns>A random unique third-level subclass, or null if no third-level subclasses are found.</returns>
            private ClassificationNode RetrieveUniqueSubclass(Stack<ClassificationNode> classCategories)
            {
                // Flatten the stack of classes to get all third-level entries
                var subclasses = new List<ClassificationNode>();

                foreach (var classCategory in classCategories)
                {
                    var thirdLevelSubclasses = RetrieveAllSubclasses(classCategory);
                    subclasses.AddRange(thirdLevelSubclasses);
                }

                // Check if there are any third-level entries
                if (subclasses.Count > 0)
                {
                    // Return a random third-level entry
                    var random = new Random();
                    return subclasses[random.Next(subclasses.Count)];
                }
                else
                {
                    return null;
                }
            }


            /// <summary>
            /// Retrieves all the subclasses of a given class category and returns them as a stack.
            /// </summary>
            /// <param name="classCategory">The class category to retrieve the subclasses from.</param>
            /// <returns>A stack of subclasses.</returns>
            private Stack<ClassificationNode> RetrieveAllSubclasses(ClassificationNode classCategory)
            {
                var subclasses = new Stack<ClassificationNode>();

                foreach (var subclass in classCategory.Subclass)
                {
                    foreach (var thirdLevelSubclass in subclass.Subclass)
                    {
                        subclasses.Push(thirdLevelSubclass);
                    }
                }

                return subclasses;
            }



            /// <summary>
            /// Retrieves a stack of unique options for a given subclass, with call numbers displayed in descending order. adapted from:https://stackoverflow.com/questions/4666602/how-to-work-with-nodes
            /// </summary>
            /// <param name="subclassSelected">The subclass for which to retrieve unique options.</param>
            /// <returns>A stack of unique options, with call numbers displayed in descending order.</returns>
            private Stack<ClassificationNode> UniqueOptions(ClassificationNode subclassSelected)
            {
                ClassificationNode firstParent = RetrieveParent(subclassSelected);
                ClassificationNode secondParent = RetrieveParent(firstParent);

                var topCategories = classes.Where(c => c != secondParent).ToList();
                var options = new List<ClassificationNode>();

                var random = new Random();
                var incorrectOptions = topCategories.OrderBy(c => random.Next()).Take(3).ToList();
                options.AddRange(incorrectOptions);

                if (secondParent != null)
                {
                    options.Add(secondParent);
                }

                options = options.OrderByDescending(c => c?.Class).ToList();

                return new Stack<ClassificationNode>(options);
            }

            /// <summary>
            /// Retrieves the parent category of a given subclass within a collection of classification nodes. https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-7.0 
            /// </summary>
            /// <param name="subclassSelected">The subclass for which to find the parent category.</param>
            /// <returns>The parent category of the specified subclass, or null if not found.</returns>
            private ClassificationNode RetrieveParent(ClassificationNode subclassSelected)
            {
                Stack<ClassificationNode> stack = new Stack<ClassificationNode>();

                foreach (var c in classes)
                {
                    stack.Push(c);
                }

                while (stack.Count > 0)
                {
                    var currentClass = stack.Pop();

                    if (currentClass.Subclass.Contains(subclassSelected))
                    {
                        return currentClass; // Found the parent category
                    }

                    foreach (var sub in currentClass.Subclass)
                    {
                        stack.Push(sub);
                    }
                }

                return null;
            }


            /// <summary>
            ///  Retrieves the parent class of a given subclass within a classification hierarchy. https://stackoverflow.com/questions/1085238/node-based-stack-class-need-peer-review
            /// </summary>
            /// <param name="subclassSelected">The subclass for which to find the parent class</param>
            /// <returns>The parent class of the specified subclass, or null if not found</returns>
            private ClassificationNode RetrieveParentClass(ClassificationNode rootClass, ClassificationNode subclassSelected)
            {
                Stack<ClassificationNode> stack = new Stack<ClassificationNode>();
                stack.Push(rootClass);

                while (stack.Count > 0)
                {
                    var currentClass = stack.Pop();

                    if (currentClass.Subclass.Contains(subclassSelected))
                    {
                        return currentClass; 
                    }

                    foreach (var sub in currentClass.Subclass)
                    {
                        stack.Push(sub);
                    }
                }

                return null; 
            }

            /// <summary>
            /// This will be responsible for reading and retrieving data from the json file. adapted from: https://stackoverflow.com/questions/8157636/can-json-net-serialize-deserialize-to-from-a-stream
            /// </summary>
            /// <param name="filePath"></param>
            private void ReadFromJSONFile(string filePath)
            {
                try
                {
                    using (StreamReader file = File.OpenText(filePath))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        classes = (Stack<ClassificationNode>)serializer.Deserialize(file, typeof(Stack<ClassificationNode>));
                        SetUniqueRelationship(classes, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FILE NOT FOUND");
                }
            }


            /// <summary>
            /// Sets the unique relationship between nodes and their parent node recursively. https://stackoverflow.com/questions/12640070/how-to-add-a-parent-node-using-foreach
            /// </summary>
            /// <param name="nodes">The collection of nodes to set the relationship for.</param>
            /// <param name="parent">The parent node to set for the nodes.</param>
            private void SetUniqueRelationship(Stack<ClassificationNode> nodes, ClassificationNode parent)
        {
            foreach (var node in nodes)
            {
                node.Parent = parent;
                    SetUniqueRelationship(node.Subclass, node);
            }
        }
    }
}
   
}
