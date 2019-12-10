using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    public class MustNotBeNullBenchmark
    {
        public SampleEntity Object;

        [GlobalSetup]
        public void GlobalSetup() => Object = new SampleEntity();

        [Benchmark(Baseline = true)]
        public SampleEntity Imperative()
        {
            if (Object == null)
                throw new ArgumentNullException(nameof(Object));

            return Object;
        }

        [Benchmark]
        public SampleEntity Old() => Object.MustNotBeNullOld(nameof(Object));

        [Benchmark]
        public SampleEntity Simple() => Object.MustNotBeNullV1(nameof(Object));

        [Benchmark]
        public SampleEntity AggressiveInlining() => Object.MustNotBeNullV2(nameof(Object));

        [Benchmark]
        public SampleEntity ExternalThrowCall() => Object.MustNotBeNullV3(nameof(Object));
    }

    public static class MustNotBeNullAssertions
    {
        public static T MustNotBeNullOld<T>(this T parameter,
                                            string parameterName = null,
                                            string message = null,
                                            Func<Exception> exception = null) where T : class
        {
            if (parameter != null)
                return parameter;

            throw exception?.Invoke() ??
                  new ArgumentNullException(parameterName, message ?? $"{parameterName ?? "The value"} must not be null.");
        }

        public static T MustNotBeNullV1<T>(this T parameter, string parameterName = null, string message = null)
            where T : class
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName, $"{message ?? "The value"} must not be null.");
            return parameter;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T MustNotBeNullV2<T>(this T parameter, string parameterName = null, string message = null)
            where T : class
        {
            if (parameter == null)
                throw new ArgumentNullException(parameterName, $"{message ?? "The value"} must not be null.");
            return parameter;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T MustNotBeNullV3<T>(this T parameter, string parameterName = null, string message = null)
            where T : class
        {
            if (parameter == null)
                Throw.ArgumentNull(parameterName, message);
            return parameter;
        }
    }

    public static class Throw
    {
        public static void ArgumentNull(string parameterName = null, string message = null) =>
            throw new ArgumentNullException(parameterName, message ?? $"{parameterName ?? "The value"} must not be null.");
    }

    public class SampleEntity
    {
        public SampleEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}