namespace roundhouse.infrastructure.logging.custom
{
    using System;
    using containers;

    public sealed class MultipleLoggerLogFactory : LogFactory
    {
        public SubLogger create_logger_bound_to(Object type)
        {
            return Container.get_an_instance_of<SubLogger>();
        }
        
    }
}