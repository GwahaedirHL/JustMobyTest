namespace AssetOperations
{
    public class LoadOperationResult<T>
    {
        public T Result { get; private set; }
        public LoadOperationStatus Status { get; private set; }

        public LoadOperationResult(T loadResult)
        {
            Result = loadResult;

            if (loadResult != null)
                Status = LoadOperationStatus.Succeeded;
            else
                Status = LoadOperationStatus.Failed;
        }

        public LoadOperationResult()
        {
            Result = default;
            Status = LoadOperationStatus.Failed;
        }
    }
}