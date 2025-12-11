using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.AlgorithmsTests
{
    using PracticeConsoleApp.Algorithms;
    using System.Collections.Generic;
    using Xunit;

    public class MergeIntervalsTests
    {
        [Fact]
        public void MergeIntervals_ShouldMergeOverlappingIntervals_BasicExample()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 3},
            new List<int>{2, 6},
            new List<int>{8, 10},
            new List<int>{15, 18}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 6},
            new List<int>{8, 10},
            new List<int>{15, 18}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldReturnSameIntervals_WhenNoOverlap()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 2},
            new List<int>{3, 4},
            new List<int>{5, 6}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 2},
            new List<int>{3, 4},
            new List<int>{5, 6}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldHandleNestedIntervals()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 10},
            new List<int>{2, 3},
            new List<int>{4, 7}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 10}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldReturnSingleInterval_WhenOnlyOneProvided()
        {
            var input = new List<List<int>>
        {
            new List<int>{5, 7}
        };

            var expected = new List<List<int>>
        {
            new List<int>{5, 7}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldReturnEmpty_WhenNoIntervals()
        {
            var input = new List<List<int>>();
            var expected = new List<List<int>>();

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldMergeTouchingIntervals()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 4},
            new List<int>{4, 5}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 5}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldHandleComplexCase()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 3},
            new List<int>{2, 4},
            new List<int>{6, 8},
            new List<int>{7, 9},
            new List<int>{10, 12}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 4},
            new List<int>{6, 9},
            new List<int>{10, 12}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldHandleZeroLengthIntervals()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 1},
            new List<int>{1, 2}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 2}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeIntervals_ShouldMergeMultipleIntoOne()
        {
            var input = new List<List<int>>
        {
            new List<int>{1, 2},
            new List<int>{2, 3},
            new List<int>{3, 4},
            new List<int>{4, 5}
        };

            var expected = new List<List<int>>
        {
            new List<int>{1, 5}
        };

            var result = MergeHighDefinitionIntervals.mergeHighDefinitionIntervals(input);
            Assert.Equal(expected, result);
        }
    }

}
